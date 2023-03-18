using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS.DataAccess.Repositories;
using SMS.Models.DataModels ;
using SMS.Models.ViewModels;
using SMS.Models.TableMapping;

namespace SMS.DataAccess
{
    public class SMSContext : DbContext
    {
        private string conn = Config.ConnectionString;

        #region "DbSet User"
        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        #endregion

        public SMSContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer(conn);
                //optionsBuilder.UseSqlServer(conn, x => x.MigrationsAssembly("WebApplication"));
                optionsBuilder.UseSqlServer(conn, x => x.MigrationsAssembly("SMS"));
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //User
            #region "user Map"
            modelBuilder.ApplyConfiguration(new StudentTableMap());
            modelBuilder.ApplyConfiguration(new TeacherTableMap());
            modelBuilder.ApplyConfiguration(new UserTableMap());
            #endregion
        }
    }
}
