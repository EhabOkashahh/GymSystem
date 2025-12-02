using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymSystem.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymSystemDAL.Data.Configurations
{
    public class SessionConfigurations : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.ToTable(tb =>
            {
                tb.HasCheckConstraint("GymSystemCapacity_Check", " Capacity between 1 and 25");
                tb.HasCheckConstraint("GymSystemDate_Check", "StartDate < EndDate");
            });   

            builder.HasOne(S => S.Category)
                   .WithMany(C => C.Sessions)
                   .HasForeignKey(S => S.CategoryID);

            builder.HasOne(S => S.Trainer)
                    .WithMany(T => T.Sessions)
                    .HasForeignKey(S => S.TrainerID);


        }
    }
}