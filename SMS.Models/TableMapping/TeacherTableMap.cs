using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS.Models.DataModels;

namespace SMS.Models.TableMapping
{
    public class TeacherTableMap : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.id).ValueGeneratedOnAdd();
            builder.Property(x => x.firstName).HasMaxLength(20).IsRequired();
            builder.Property(x => x.lastName).HasMaxLength(20).IsRequired();
            builder.Property(x => x.dob);
            builder.Property(x => x.email).HasMaxLength(50).IsRequired();
            builder.Property(x => x.phoneNumber).HasMaxLength(20).IsRequired();
        }
    }
}

