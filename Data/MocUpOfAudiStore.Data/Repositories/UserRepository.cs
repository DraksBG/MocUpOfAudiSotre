namespace MocUpOfAudiStore.Data.Repositories
{
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Interfaces;
    using Models;

    public class UserRepository : BaseRepository<ApplicationUser>, IUserRepository
    {
        public UserRepository(DbContext dbContext)
            : base(dbContext)
        {
        }

        public async Task<ApplicationUser> GetByEmailOrDefault(string email)
        {
            var user = await GetAll()
                .Where(u => u.NormalizedEmail == email.ToUpper())
                .FirstOrDefaultAsync();

            return user;
        }

        public async Task<ApplicationUser> GetByIdWithRolesAsync(string userId)
        {
            var dbUser = await GetAll()
                .Include(u => u.Roles)
                .Where(u => u.Id == userId)
                .FirstOrDefaultAsync();

            return dbUser;
        }
    }
}