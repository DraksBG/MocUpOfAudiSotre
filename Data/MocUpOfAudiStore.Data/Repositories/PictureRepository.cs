namespace MocUpOfAudiStore.Data.Repositories
{
    using MocUpOfAudiStore.Data.Interfaces;
    using MocUpOfAudiStore.Data.Models;

    public class PictureRepository : BaseRepository<Picture>, IPictureRepository
    {
        public PictureRepository(ApplicationDbContext dbContext)
            : base(dbContext) { }
    }
}
