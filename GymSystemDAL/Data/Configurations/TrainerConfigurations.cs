using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymSystem.DAL.Data.Configurations;
using GymSystem.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace GymSystemDAL.Data.Configurations
{
    public class TrainerConfigurations : GymUserConfigurations<Trainer>, IEntityTypeConfiguration<Trainer>
    {
        public new void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Trainer> builder)
        {
            builder.Property(T => T.CreatedAt).HasColumnName("HireDate").HasDefaultValueSql("GETDATE()");
            base.Configure(builder);
            
        }
    }
}