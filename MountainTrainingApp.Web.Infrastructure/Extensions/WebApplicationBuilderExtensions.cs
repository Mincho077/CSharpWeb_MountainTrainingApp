
using System.Reflection;

namespace MountainTrainingApp.Web.Infrastructure.Extensions
{
    public static class WebApplicationBuilderExtensions
    {
        //public static void AddApplicationServices(this IServiceCollection services, Type serviceType)
        //{
        //    Assembly? serciceAssembly = Assembly.GetAssembly(serviceType);

        //    if (serciceAssembly == null)
        //    {
        //        throw new InvalidOperationException("Invalid service type provider!");
        //    }

        //    Type[] serviceTypes = serciceAssembly
        //        .GetTypes()
        //        .Where(t => t.Name.EndsWith("Service") && !t.IsInterface)
        //        .ToArray();

        //    foreach (var implementationType in serviceTypes)
        //    {
        //        Type? interfaceType = implementationType.GetInterface($"I{implementationType.Name}");
        //        if (interfaceType == null)
        //        {
        //            throw new InvalidOperationException
        //                ($"No iterface is provided for service with name {implementationType.Name}");
        //        }

        //        services.AddScoped(interfaceType, implementationType);
        //    }

        //}
    }
}
