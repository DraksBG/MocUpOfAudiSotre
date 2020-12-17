namespace MocUpOfAudiStore.Common.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class RepositoryUpdateNoRowsAffectedException : Exception
    {
        public RepositoryUpdateNoRowsAffectedException()
            : base()
        {
        }

        public RepositoryUpdateNoRowsAffectedException(string message)
            : base(message)
        {
        }

        public RepositoryUpdateNoRowsAffectedException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
