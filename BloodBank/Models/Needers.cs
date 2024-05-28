using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace BloodBank.Models
{
    public class Needers
    {
        [Key]
        public int needer_id { get; set; }

        
        [Required(ErrorMessage = "Enter The Name")]
        [Display(Name = "Name")]
        public string needer_name { get; set; }

        
        [Required(ErrorMessage = "Enter The Phone Nunber")]
        [Display(Name = "Phone")]
        public string phone { get; set; }

        
        [Required(ErrorMessage = "Enter The Gender")]
        [Display(Name = "Gender")]
        public string gender { get; set; }

        
        [Required(ErrorMessage = "Enter The Email")]
        [Display(Name = "Email Adress")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }


       
        [Required(ErrorMessage = "Enter The BloodType")]
        [Display(Name = "BloodType")]
        public string BloodType { get; set; }


        //public int doctor_id { get; set; }
        //[ForeignKey("doctor_id")]
        //public Doctor Doctor { get; set; }
    }
}
