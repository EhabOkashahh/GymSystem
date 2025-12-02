using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymSystemDAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymSystemDAL.Data.Configurations
{
    public class MemberSessionConfigurations : IEntityTypeConfiguration<MemberSessions>
    {
        public void Configure(EntityTypeBuilder<MemberSessions> builder)
        {
            builder.HasKey(MS => new { MS.MemberID, MS.SessionID });
            builder.Ignore(X => X.Id);

            builder.HasOne(MS => MS.Member).WithMany(M => M.MemberSessions).HasForeignKey(MS => MS.MemberID);
            builder.HasOne(MS => MS.Session).WithMany(M => M.MemberSessions).HasForeignKey(MS => MS.SessionID);

            builder.ToTable("MemberSessions");
        }
    }
}