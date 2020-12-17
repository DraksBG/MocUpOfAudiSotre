namespace MocUpOfAudiStore.Data.Repositories
{
    using Interfaces;
    using Models;

    public class PictureRepository : BaseRepository<Picture>, IPictureRepository
    {
        public PictureRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}