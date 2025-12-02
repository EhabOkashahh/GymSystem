using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymSystem.DAL.Entities;

namespace GymSystemDAL.Entities
{
    public class MemberShip : BaseEntity
    {
        public Member Member { get; set; } = null!;
        public int MemberID { get; set; }


        public Plan Plan { get; set; } = null!;
        public int PlanID { get; set; }

        public DateTime EndDate { get; set; }
        public string status {
            get
            {
                if(EndDate >= DateTime.Now) return "Expired";
                else return "Active";
            }
        }
    }
}