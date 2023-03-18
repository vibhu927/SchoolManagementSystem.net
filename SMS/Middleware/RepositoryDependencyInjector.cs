

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SMS.DataAccess.Repositories.Contracts;
using SMS.DataAccess.Repositories;

namespace SMS.Middleware
{
    public static class RepositoryDependencyInjector
    {
        public static IServiceCollection AddInternalRepositories(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<ITeacherRepository, TeacherReporsitory>();
            services.AddTransient<IStudentRepository, StudentRepository>();
            return services;
        }
    }
}
