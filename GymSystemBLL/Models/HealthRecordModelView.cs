using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GymSystemBLL.Models
{
    public class HealthRecordModelView
    {
        [Required(ErrorMessage = "Height Is Required")]
        [Range(0.1,300,ErrorMessage = "Height must be within Range 0.1 and 300")]
        public decimal Height { get; set; }



        [Required(ErrorMessage = "Weight Is Required")]
        [Range(0.1,500,ErrorMessage = "Weight must be within Range 0.1 and 300")]
        public decimal Weight { get; set; }



        [Required(ErrorMessage = "BloodType Is Required")]
        [StringLength(3,ErrorMessage = "BloodType must be At max 3 char")]
        public string  BloodType { get; set; } = null!;
        public string? Note { get; set; }
    }
}