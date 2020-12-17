namespace MocUpOfAudiStore.Data.Repositories
{
    using Interfaces;
    using Models;

    public class TestDriveRepository : BaseRepository<TestDrive>, ITestDriveRepository
    {
        public TestDriveRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}