using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymSystem.DAL.Entites.Enums;
using Microsoft.EntityFrameworkCore;

namespace GymSystem.DAL.Entities
{
    public class GymUser : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public Address Address { get; set; }
    }

    [Owned]
    public class Address
    {
        public string BuildingNo{ get; set; }
        public string Street{ get; set; }
        public string City{ get; set; }
    }
}