namespace MocUpOfAudiStore.Data.Repositories
{
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using MocUpOfAudiStore.Data.Interfaces;

    public class RoleRepository : BaseRepository<IdentityRole>, IRoleRepository
    {
        public RoleRepository(ApplicationDbContext dbContext)
            : base(dbContext) { }

        public async Task<string> GetIdByNameAsync(string name)
        {
            var dbRole = await this.GetAll()
                .Where(r => r.NormalizedName == name.ToUpper())
                .Select(r => new { r.Id })
                .FirstAsync();

            return dbRole.Id;
        }
    }
}
