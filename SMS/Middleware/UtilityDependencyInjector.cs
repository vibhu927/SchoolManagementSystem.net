
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvitaMedicalClinic.Middleware
{
    public static class UtilityDependencyInjector
    {
        public static IServiceCollection AddInternalUtilities(this IServiceCollection services)
        {
            //services.AddSingleton<IEncryptionManager, EncryptionManager>();
            return services;
        }

       
    }
}
