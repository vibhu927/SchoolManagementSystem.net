using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SMS.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Models.TableMapping
{
    public class StudentTableMap : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
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
