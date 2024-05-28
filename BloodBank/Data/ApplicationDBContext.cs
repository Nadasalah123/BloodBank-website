using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using BloodBank.Models;
using System.Drawing;


namespace BloodBank.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<Donors> Donors { get; set; }
        public DbSet<Needers> Needers { get; set; }
        public DbSet<Communucation> Communucations { get; set; }
        public DbSet<stocks> stocks { get; set; }

    }
}
