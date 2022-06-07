using TimesheetManagement.Contracts.Logging;
using TimesheetManagement.Utils.Logging;

namespace TimesheetManagement.API.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("TM.APICorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });
        }

        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerService, LoggerService>();
        }
    }
}
