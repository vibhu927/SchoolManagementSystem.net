
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using SMS.Service.Services;
using SMS.Service.Services.Contracts;
using SMS.DataAccess.Repositories.Contracts;
using SMS.DataAccess.Repositories;

namespace SMS.Middleware
{
    public static class ServiceDependencyInjector
    {
        public static IServiceCollection AddInternalServices(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IStudentService, StudentService>();
            services.AddTransient<ILoginService, LoginService>();
            services.AddTransient<ITeacherService, TeacherService>();
           
            return services;
        }

        private static void AddLogger(IServiceCollection services, IConfiguration configuration)
        {
            var logLevel = (Microsoft.Extensions.Logging.LogLevel)Enum.Parse(typeof(Microsoft.Extensions.Logging.LogLevel), configuration.GetSection("Logging:LogLevel:Default").Value);
            var nLogConfig = configuration.GetSection("NLog");

            services.AddLogging(logBuilder =>
            {
                logBuilder.ClearProviders();
                logBuilder.SetMinimumLevel(logLevel);

                LogManager.Configuration = new NLogLoggingConfiguration(nLogConfig);
                logBuilder.AddNLog(nLogConfig);
            });
        }
    }
}
