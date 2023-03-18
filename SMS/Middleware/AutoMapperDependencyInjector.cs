using AutoMapper;
using SMS.Common.AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMS.Middleware
{
    public static class AutoMapperDependencyInjector
    {
        public static IServiceCollection AddAutoMapperProfiles(this IServiceCollection services)
        {
            //Auto Mapper Configurations DI
            var mappingConfig = new MapperConfiguration(mc =>
            {
                //Add all profiles here
                mc.AddProfile(new UserProfile());
                mc.AddProfile(new TeacherProfile());
                mc.AddProfile(new StudentProfile());

            });
            
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            return services;
        }
    }
}
