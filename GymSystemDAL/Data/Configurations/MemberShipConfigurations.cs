using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymSystemDAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymSystemDAL.Data.Configurations
{
    public class MemberShipConfigurations : IEntityTypeConfiguration<MemberShip>
    {
        public void Configure(EntityTypeBuilder<MemberShip> builder)
        {
            builder.Property(MS => MS.CreatedAt).HasColumnName("StartDate").HasDefaultValueSql("GETDATE()");
            builder.HasKey(X => new {X.MemberID , X.PlanID});
            builder.Ignore(X => X.Id);
        }
    }
}