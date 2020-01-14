using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFGetStarted
{
    public class RoleConfiguration :  IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            // Primary Key
            builder.HasKey(t => t.RoleID);

            // Properties
            builder.Property(t => t.RoleName)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            builder.ToTable("Role", "dbo");
            builder.Property(t => t.RoleID).HasColumnName("RoleID");
            builder.Property(t => t.RoleName).HasColumnName("RoleName");
        }
    }
}