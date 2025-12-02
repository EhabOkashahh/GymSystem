using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymSystem.DAL.Entities;

namespace GymSystemDAL.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        IGenericRepository<T> GenerateRepository<T>() where T : BaseEntity;
        Task<int> ApplyToDataBaseAsync();
    }
}