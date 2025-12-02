using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using GymSystem.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymSystem.DAL.Data.Configurations
{
    public class GymUserConfigurations<T> : IEntityTypeConfiguration<T> where T : GymUser
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(u => u.Name).HasColumnType("varchar").HasMaxLength(50);
            builder.Property(u => u.Email).HasColumnType("varchar").HasMaxLength(100);

            builder.ToTable(tb =>
            {
                tb.HasCheckConstraint("GymUserValidEmailCheck","Email Like '%_@_%._%'");
                tb.HasCheckConstraint("GymUserValidPhoneCheck","Phone Like '01%' and Phone Not like '%[^0-9]%'");
            });

            builder.HasIndex(U=>U.Email).IsUnique();
            builder.HasIndex(U=>U.Phone).IsUnique();

            builder.OwnsOne(u => u.Address, a =>
            {
                a.Property(ad => ad.Street).HasMaxLength(100).HasColumnName("Street");
                a.Property(ad => ad.City).HasMaxLength(50).HasColumnName("City");
            });

        }
    }
}