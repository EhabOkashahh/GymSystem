using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymSystem.DAL.Entities
{
    public class HealthRecord : BaseEntity
    {
        //Id => FK to the user
       public decimal Weight { get; set; }
       public decimal Height { get; set; }
       public string BloodType { get; set; } = null!;
       public string? Note { get; set; }
    }
}