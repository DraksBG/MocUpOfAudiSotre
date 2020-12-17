namespace MocUpOfAudiStore.Common.Validation
{
    using MocUpOfAudiStore.Common.Constants;
    using MocUpOfAudiStore.Common.Exceptions;

    public class RepositoryValidator
    {
        public static void ValidateCompleteChanges(int rowsAffected)
        {
            if (rowsAffected == 0)
            {
                throw new RepositoryUpdateNoRowsAffectedException(ErrorConstants.UnitOfWorkNoRowsAffected);
            }
        }
    }
}
