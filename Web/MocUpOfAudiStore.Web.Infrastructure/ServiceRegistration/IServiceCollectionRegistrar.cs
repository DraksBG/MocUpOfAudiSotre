namespace MocUpOfAudiStore.Web.Infrastructure.ServiceRegistration
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IServiceCollectionRegistrar
    {
        void AddScopedServices(Type type);
    }
}
