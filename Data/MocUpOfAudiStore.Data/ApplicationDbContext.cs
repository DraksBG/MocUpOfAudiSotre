namespace MocUpOfAudiStore.Data
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Threading;
    using System.Threading.Tasks;

    using MocUpOfAudiStore.Data.Common.Models;
    using MocUpOfAudiStore.Data.Models;

    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        private static readonly MethodInfo SetIsDeletedQueryFilterMethod =
            typeof(ApplicationDbContext).GetMethod(
                nameof(SetIsDeletedQueryFilter),
                BindingFlags.NonPublic | BindingFlags.Static);

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Setting> Settings { get; set; }

        public DbSet<BaseCar> BaseCars { get; set; }

        public DbSet<CarOption> CarsOptions { get; set; }

        public DbSet<Engine> Engines { get; set; }

        public DbSet<FuelType> FuelTypes { get; set; }

        public DbSet<ModelType> ModelTypes { get; set; }

        public DbSet<NewCar> NewCars { get; set; }

        public DbSet<Option> Options { get; set; }

        public DbSet<OptionType> OptionTypes { get; set; }

        public DbSet<TestDrive> TestDrives { get; set; }

        public DbSet<Status> Statuses { get; set; }

        public DbSet<Picture> Pictures { get; set; }

        public DbSet<Series> Series { get; set; }

        public DbSet<Transmission> Transmissions { get; set; }

        public DbSet<UsedCar> UsedCars { get; set; }

        public new DbSet<ApplicationUser> Users { get; set; }

        public override int SaveChanges() => this.SaveChanges(true);

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            this.ApplyAuditInfoRules();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) =>
            this.SaveChangesAsync(true, cancellationToken);

        public override Task<int> SaveChangesAsync(
            bool acceptAllChangesOnSuccess,
            CancellationToken cancellationToken = default)
        {
            this.ApplyAuditInfoRules();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Needed for Identity models configuration
            base.OnModelCreating(builder);

            this.ConfigureUserIdentityRelations(builder);

            EntityIndexesConfiguration.Configure(builder);

            var entityTypes = builder.Model.GetEntityTypes().ToList();

            // Set global query filter for not deleted entities only
            var deletableEntityTypes = entityTypes
                .Where(et => et.ClrType != null && typeof(IDeletableEntity).IsAssignableFrom(et.ClrType));
            foreach (var deletableEntityType in deletableEntityTypes)
            {
                var method = SetIsDeletedQueryFilterMethod.MakeGenericMethod(deletableEntityType.ClrType);
                method.Invoke(null, new object[] { builder });
            }

            // Disable cascade delete
            var foreignKeys = entityTypes
                .SelectMany(e => e.GetForeignKeys().Where(f => f.DeleteBehavior == DeleteBehavior.Cascade));
            foreach (var foreignKey in foreignKeys)
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }

            builder.Entity<BaseCar>(car =>
            {
                car.HasKey(c => c.Id);

                car.HasOne(c => c.Engine)
                    .WithMany(e => e.Cars)
                    .HasForeignKey(c => c.EngineId)
                    .OnDelete(DeleteBehavior.Restrict);

                car.HasOne(c => c.FuelType)
                    .WithMany(ft => ft.Cars)
                    .HasForeignKey(c => c.FuelTypeId)
                    .OnDelete(DeleteBehavior.Restrict);

                car.HasOne(c => c.ModelType)
                    .WithMany(mt => mt.Cars)
                    .HasForeignKey(c => c.ModelTypeId)
                    .OnDelete(DeleteBehavior.Restrict);

                car.HasOne(c => c.Series)
                    .WithMany(s => s.Cars)
                    .HasForeignKey(c => c.SeriesId)
                    .OnDelete(DeleteBehavior.Restrict);

                car.HasMany(c => c.TestDrives)
                    .WithOne(b => b.Car)
                    .HasForeignKey(uc => uc.CarId)
                    .OnDelete(DeleteBehavior.Cascade);

                car.HasMany(c => c.Options)
                    .WithOne(o => o.Car)
                    .HasForeignKey(o => o.CarId)
                    .OnDelete(DeleteBehavior.Cascade);

                car.HasMany(c => c.Pictures)
                    .WithOne(p => p.Car)
                    .HasForeignKey(p => p.CarId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            builder.Entity<CarOption>(carOption =>
            {
                carOption.HasKey(co => co.Id);

                carOption.HasIndex(co => new { co.OptionId, co.CarId })
                    .IsUnique();

                carOption.HasOne(co => co.Car)
                    .WithMany(c => c.Options)
                    .HasForeignKey(co => co.CarId)
                    .OnDelete(DeleteBehavior.Cascade);

                carOption.HasOne(co => co.Option)
                    .WithMany(o => o.CarsOptions)
                    .HasForeignKey(co => co.OptionId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<Engine>(engine =>
            {
                engine.HasKey(e => e.Id);

                engine.HasIndex(e => e.Name)
                    .IsUnique();

                engine.HasOne(e => e.Transmission)
                    .WithMany(t => t.Engines)
                    .HasForeignKey(e => e.TransmissionId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<FuelType>(fuelType =>
            {
                fuelType.HasKey(ft => ft.Id);

                fuelType.HasIndex(ft => ft.Name)
                    .IsUnique();
            });

            builder.Entity<ModelType>(modelType =>
            {
                modelType.HasKey(mt => mt.Id);

                modelType.HasIndex(mt => mt.Name)
                    .IsUnique();
            });

            builder.Entity<Option>(option =>
            {
                option.HasKey(o => o.Id);

                option.HasIndex(o => o.Name)
                    .IsUnique();

                option.HasMany(o => o.CarsOptions)
                    .WithOne(c => c.Option)
                    .HasForeignKey(c => c.OptionId)
                    .OnDelete(DeleteBehavior.Cascade);

                option.HasOne(o => o.OptionType)
                    .WithMany(ot => ot.Options)
                    .HasForeignKey(o => o.OptionTypeId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            builder.Entity<OptionType>(optionType =>
            {
                optionType.HasKey(ot => ot.Id);

                optionType.HasIndex(ot => ot.Name)
                    .IsUnique();

                optionType.HasMany(ot => ot.Options)
                    .WithOne(o => o.OptionType)
                    .HasForeignKey(o => o.OptionTypeId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            builder.Entity<TestDrive>(testDrive =>
            {
                testDrive.HasKey(td => td.Id);

                testDrive.Property(td => td.ScheduleDate)
                    .HasDefaultValue(DateTime.UtcNow);

                testDrive.HasOne(td => td.Status)
                    .WithMany(s => s.TestDrives)
                    .HasForeignKey(td => td.StatusId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<Status>(status =>
            {
                status.HasKey(s => s.Id);

                status.HasIndex(s => s.Name)
                    .IsUnique();

                status.HasMany(s => s.TestDrives)
                    .WithOne(s => s.Status)
                    .HasForeignKey(s => s.StatusId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<Picture>(pictures =>
            {
                pictures.HasKey(p => p.Id);
            });

            builder.Entity<Series>(series =>
            {
                series.HasKey(s => s.Id);

                series.HasIndex(s => s.Name)
                    .IsUnique();

                series.HasIndex(s => s.Name)
                    .IsUnique();
            });

            builder.Entity<Transmission>(transmissions =>
            {
                transmissions.HasKey(t => t.Id);

                transmissions.HasIndex(t => t.Name)
                    .IsUnique();

                transmissions.HasMany(t => t.Engines)
                    .WithOne(e => e.Transmission)
                    .HasForeignKey(t => t.TransmissionId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<ApplicationUser>(user =>
            {
                user.HasMany(c => c.TestDrives)
                    .WithOne(bc => bc.User)
                    .HasForeignKey(bc => bc.UserId)
                    .OnDelete(DeleteBehavior.Restrict);

                user.HasMany(u => u.Roles)
                    .WithOne()
                    .HasForeignKey(r => r.UserId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }

        private static void SetIsDeletedQueryFilter<T>(ModelBuilder builder)
            where T : class, IDeletableEntity
        {
            builder.Entity<T>().HasQueryFilter(e => !e.IsDeleted);
        }

        // Applies configurations
        private void ConfigureUserIdentityRelations(ModelBuilder builder)
             => builder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);

        private void ApplyAuditInfoRules()
        {
            var changedEntries = this.ChangeTracker
                .Entries()
                .Where(e =>
                    e.Entity is IAuditInfo &&
                    (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entry in changedEntries)
            {
                var entity = (IAuditInfo)entry.Entity;
                if (entry.State == EntityState.Added && entity.CreatedOn == default)
                {
                    entity.CreatedOn = DateTime.UtcNow;
                }
                else
                {
                    entity.ModifiedOn = DateTime.UtcNow;
                }
            }
        }
    }
}
