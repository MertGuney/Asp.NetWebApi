using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using WebApiForAngular.Entity.Concrete;

namespace WebApiForAngular.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class EmployeeMap : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(I => I.EmployeeId);
            builder.Property(I => I.EmployeeId).UseIdentityColumn();

            builder.Property(I => I.EmployeeName).HasMaxLength(500);

            builder.Property(I => I.Department).HasMaxLength(500);

            builder.Property(I => I.DateOfJoining).HasDefaultValue(DateTime.Now);

            builder.Property(I => I.PhotoFileName).HasMaxLength(500);

        }
    }
}
