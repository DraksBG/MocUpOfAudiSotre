namespace MocUpOfAudiStore.Web.Infrastructure.ServiceRegistration
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using Microsoft.Extensions.DependencyInjection;
    using MocUpOfAudiStore.Web.Infrastructure.ServiceRegistration.ErrorConstatns;

    public class ServiceCollectionRegistrar : IServiceCollectionRegistrar
    {
        private readonly IServiceCollection services;

        private readonly ICollection<Type> typesToIngore;

        public ServiceCollectionRegistrar(IServiceCollection services)
        {
            this.services = services;
            this.typesToIngore = new List<Type>();
        }

        public void AddScopedServices(Type type)
        {
            var allClassesTypes = this.GetClassesTypes(type);

            foreach (var classType in allClassesTypes)
            {
                if (this.typesToIngore.Contains(classType))
                {
                    continue;
                }

                var interfaceTypes = classType.GetInterfaces();
                this.ValidateInterfaces(interfaceTypes, classType.ToString());

                var interfaceToRegister = this.GetClassInterfaceTypeToRegister(classType, interfaceTypes);

                services.AddScoped(interfaceToRegister, classType);
            }
        }

        private IEnumerable<Type> GetClassesTypes(Type type)
        {
            var nameSpace = type.Namespace;
            var assembly = Assembly.GetAssembly(type);
            var allClassesTypes = this.GetTypesFromAssembly(assembly, t => t.IsClass && t.Namespace == nameSpace);

            return allClassesTypes;
        }

        private IEnumerable<Type> GetTypesFromAssembly(Assembly assembly, Func<Type, bool> func)
        {
            var classesTypes = new List<Type>();

            var servicesTypes = assembly.GetTypes();
            foreach (var type in servicesTypes)
            {
                if (IsCompilerGenerated(type) == false && func(type))
                {
                    classesTypes.Add(type);
                }
            }

            return classesTypes;
        }

        private bool IsCompilerGenerated(Type type)
        {
            return type.GetCustomAttribute<CompilerGeneratedAttribute>() != null;
        }

        private void ValidateInterfaces(Type[] interfaceTypes, string className)
        {
            if (interfaceTypes.Length < 1)
            {
                var exceptionMessage = CosntatnsErrors.ZeroInterfaces + $" for ({className})";
                throw new InvalidOperationException(exceptionMessage);
            }
        }

        private Type GetClassInterfaceTypeToRegister(Type classType, Type[] classInterfaces)
        {
            var classTypeInterfaceName = $"I{classType.Name}";
            foreach (var classInterface in classInterfaces)
            {
                var interfaceName = classInterface.Name;

                if (classTypeInterfaceName == interfaceName)
                {
                    return classInterface;
                }
            }

            var exceptionMessage = CosntatnsErrors.MatchingInterfaceNotFound + $" for ({classType})";
            throw new InvalidOperationException(exceptionMessage);
        }

        public void AddIgnored(params Type[] typesToIgnore)
        {
            foreach (var type in typesToIgnore)
            {
                this.typesToIngore.Add(type);
            }
        }
    }
}
