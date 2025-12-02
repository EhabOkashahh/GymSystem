using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymSystem.DAL.Entities;
using GymSystemBLL.Services.Interfaces;
using GymSystemDAL.Repositories.Interfaces;
using Microsoft.VisualBasic;

namespace GymSystemBLL.Services.Classes
{
    public class MemberService(IUnitOfWork _UnitOfWork) : IMemberService
    {
        
        public Task<IEnumerable<Member>> GetAllMembersAsync() => _UnitOfWork.GenerateRepository<Member>().GetAllAsync();
        

        public Task<Member> GetMemberByIdAsync(int? id)
        {
            if(id is null) throw new Exception("Member Was Not Found");
            return _UnitOfWork.GenerateRepository<Member>().GetByIdAsync(id.Value);
        }
        public async Task<int> AddMemberAsync(Member member)
        {
            
            if(member is null) throw new Exception("Something went wrong can not add this Member, try again later");
            await _UnitOfWork.GenerateRepository<Member>().AddAsync(member);
            return await _UnitOfWork.ApplyToDataBaseAsync();
            
        }

        public async Task<int> DeleteMember(int? id)
        {
            if(id is null) throw new Exception("Member Was Not Found");
            await _UnitOfWork.GenerateRepository<Member>().Delete(id.Value);
            return await _UnitOfWork.ApplyToDataBaseAsync();
        }
        public async Task<int> UpdateMember(Member member)
        {
             if(member is null) throw new Exception("Something went wrong can not Update this Member, try again later");
            _UnitOfWork.GenerateRepository<Member>().Update(member);
            return await _UnitOfWork.ApplyToDataBaseAsync();
        }
    }
}