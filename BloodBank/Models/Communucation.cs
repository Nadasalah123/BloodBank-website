using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace BloodBank.Models
{
    public class Communucation
    {
        [Key]
        public int person_id { get; set; }


        [Required(ErrorMessage = "Enter The Name")]
        [Display(Name = "Name")]
        public string person_name { get; set; } = "";


        
        [Required(ErrorMessage = "Enter The Email")]
        [Display(Name = "Email Adress")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        
        [Display(Name = "subject")]
        public string subject { get; set; }

       
        [Display(Name = "message")]
        public string message { get; set; }



        //[StringLength(100)]
        //public int doctor_id { get; set; }
        //[ForeignKey("doctor_id")]
        //public Doctor Doctor { get; set; }
    }
}
