using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApiForAngular.Entity.Concrete;

namespace WebApiForAngular.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class DepartmentMap : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(I => I.DepartmentID);
            builder.Property(I => I.DepartmentID).UseIdentityColumn();

            builder.Property(I => I.DepartmentName).HasMaxLength(500);
        }
    }
}
