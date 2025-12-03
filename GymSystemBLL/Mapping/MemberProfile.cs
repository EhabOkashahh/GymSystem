using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GymSystem.DAL.Entities;
using GymSystemBLL.Models;

namespace GymSystemBLL.Mapping
{
    public class MemberProfile : Profile
    {
        public MemberProfile()
        {
            CreateMap<Member,CreateMemberModelView>().ReverseMap();
            CreateMap<Member,MemberModelView>().ReverseMap();
            CreateMap<Member,UpdateMemberModelView>().ReverseMap();
        }
    }
}