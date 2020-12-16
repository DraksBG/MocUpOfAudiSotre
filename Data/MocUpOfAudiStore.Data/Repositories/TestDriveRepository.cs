namespace MocUpOfAudiStore.Data.Repositories
{
    using MocUpOfAudiStore.Data.Interfaces;
    using MocUpOfAudiStore.Data.Models;

    public class TestDriveRepository : BaseRepository<TestDrive>, ITestDriveRepository
    {
        public TestDriveRepository(ApplicationDbContext dbContext)
            : base(dbContext) { }
    }
}
