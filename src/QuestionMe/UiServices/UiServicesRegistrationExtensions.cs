using System.Reflection;

namespace QuestionMe.UiServices
{
    public static class UiServicesRegistrationExtensions
    {
        public static IServiceCollection AddUiServices(this IServiceCollection services)
        {
            services.Scan(scan =>
               scan.FromAssemblies(typeof(UiServicesRegistrationExtensions).Assembly)
               .AddClasses(s => s.AssignableTo<IUiService>())
               .AsSelf()
               .AsImplementedInterfaces());

            return services;
        }
    }
}
