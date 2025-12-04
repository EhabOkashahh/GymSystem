using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymSystemBLL.Models
{
    public class MemberModelView
    {
        public int id { get; set; } 
        public string? Photo { get; set; } 
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public string Phone { get; set; } = null!;


        // For Details
        public string? PlanName { get; set; }
        public string? DateOfBirth { get; set; }
        public string? MemberShipStartedDate { get; set; }
        public string? MemberShipEndDate { get; set; }
        public string? Address { get; set; }
    }
}