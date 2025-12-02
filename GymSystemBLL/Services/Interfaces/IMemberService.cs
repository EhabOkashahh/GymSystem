using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymSystem.DAL.Entities;

namespace GymSystemBLL.Services.Interfaces
{
    public interface IMemberService
    {
        Task<IEnumerable<Member>> GetAllMembersAsync();
        Task<Member> GetMemberByIdAsync(int? id);
        Task<int> AddMemberAsync(Member member);
        Task<int> UpdateMember(Member member);
        Task<int> DeleteMember(int? id);
    }
}