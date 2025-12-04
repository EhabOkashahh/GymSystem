using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymSystemBLL.Models.PlanModels;

namespace GymSystemBLL.Services.Interfaces
{
    public interface IPlanService
    {
        Task<IEnumerable<PlanModelView>> GetAllPlans();
        Task<PlanModelView?> GetPlanDetails(int? id);
        Task<bool> UpdatePlanData(int id,UpdatePlanModelView model);
        Task<bool> TogglePlanActiveStatus(int id); 
        
    }
}