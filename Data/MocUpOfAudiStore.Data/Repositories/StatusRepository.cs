namespace MocUpOfAudiStore.Data.Repositories
{
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using MocUpOfAudiStore.Data.Interfaces;
    using MocUpOfAudiStore.Data.Models;

    public class StatusRepository : BaseRepository<Status>, IStatusRepository
    {
        public StatusRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }

        public async Task<string> GetIdByNameAsync(string name)
        {
            var id = await this.GetAll()
                .Where(s => s.Name == name)
                .Select(s => s.Id)
                .FirstAsync();

            return id;
        }
    }
}
