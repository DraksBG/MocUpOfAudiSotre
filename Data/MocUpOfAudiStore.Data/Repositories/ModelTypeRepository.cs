namespace MocUpOfAudiStore.Data.Repositories
{
    using MocUpOfAudiStore.Data.Interfaces;
    using MocUpOfAudiStore.Data.Models;

    public class ModelTypeRepository : BaseRepository<ModelType>, IModelTypeRepository
    {
        public ModelTypeRepository(ApplicationDbContext dbContext)
            : base(dbContext) { }
    }
}
