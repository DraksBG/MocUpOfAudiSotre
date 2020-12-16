namespace MocUpOfAudiStore.Data.Repositories
{
    using MocUpOfAudiStore.Data.Interfaces;
    using MocUpOfAudiStore.Data.Models;

    public class TransmissionRepository : BaseRepository<Transmission>, ITransmissionRepository
    {
        public TransmissionRepository(ApplicationDbContext dbContext)
            : base(dbContext) { }
    }
}
