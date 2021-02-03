using BlogProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Data.Concrete.EntityFramework.Mappings
{
    public class RoleMap : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id).ValueGeneratedOnAdd();
            builder.Property(r => r.Name).IsRequired();
            builder.Property(r => r.Name).HasMaxLength(30);
            builder.Property(r => r.Description).IsRequired();
            builder.Property(r => r.Description).HasMaxLength(250);
            builder.Property(r => r.CreatedByName).IsRequired();
            builder.Property(r => r.CreatedByName).HasMaxLength(50);
            builder.Property(r => r.ModifiedByName).IsRequired();
            builder.Property(r => r.ModifiedByName).HasMaxLength(50);
            builder.Property(r => r.CreatedDate).IsRequired();
            builder.Property(r => r.ModifiedDate).IsRequired();
            builder.Property(r => r.IsActive).IsRequired();
            builder.Property(r => r.IsDeleted).IsRequired();
            builder.Property(r => r.Note).HasMaxLength(500);
            builder.ToTable("Roles");

            //initializer ile farklı intializer icinde var mı yokmu diye kkontrol etmem lazımdı fakat burda direkt tablo oluşurken ekler ve kalır.

            builder.HasData(new Role
            {
                Id = 1,
                CreatedDate = DateTime.Now,
                CreatedByName = "InitializerCreated",
                Description = "Admin Rolü ve Tüm işlemlerde yetkilidir.",
                IsActive = true,
                IsDeleted = false,
                ModifiedByName = "InitialCreated.",
                ModifiedDate = DateTime.Now,
                Name="Admin",
                Note="Admin Rolü."
            });
        }
    }
}
