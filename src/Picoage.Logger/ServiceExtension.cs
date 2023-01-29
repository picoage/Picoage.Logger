using Microsoft.Extensions.DependencyInjection;

namespace Picoage.Logger
{
    public static class ServiceExtension
    {
       public static void AddApplicationInsightLogger(this IServiceCollection services)
        {
            services.AddApplicationInsightsTelemetry();
            services.AddSingleton(typeof(IPicoageLogger<>), typeof(PicoageLogger<>)); 
        }
    }
}
