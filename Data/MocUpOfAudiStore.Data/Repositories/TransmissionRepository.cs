namespace MocUpOfAudiStore.Data.Repositories
{
    using Interfaces;
    using Models;

    public class TransmissionRepository : BaseRepository<Transmission>, ITransmissionRepository
    {
        public TransmissionRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}