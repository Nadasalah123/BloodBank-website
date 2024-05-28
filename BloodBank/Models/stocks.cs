using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Drawing;


namespace BloodBank.Models
{
    public class stocks
    {
        [Key]
        public int stock_id { get; set; }

       
        [Required(ErrorMessage = "Enter The Name")]
        public string stock_name { get; set; }



        public int donor_id { get; set; }
        [ForeignKey("donor_id")]
        public Donors Donors { get; set; }


        [StringLength(100)]
        public int needer_id { get; set; }
        [ForeignKey("needer_id")]
        public Needers Needers { get; set; }
    }
}
