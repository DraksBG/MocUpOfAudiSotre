namespace MocUpOfAudiStore.Data.Repositories
{
    using Interfaces;
    using Models;

    public class ModelTypeRepository : BaseRepository<ModelType>, IModelTypeRepository
    {
        public ModelTypeRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}