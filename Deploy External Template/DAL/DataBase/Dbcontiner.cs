using Deploy_External_Template.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deploy_External_Template.DAL.DataBase
{
    public class Dbcontiner : DbContext
    {
        public DbSet<Department> Departments{get; set;}
        public DbSet<Employee> Employees { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server=.;database=mario;integrated security=false;user=marco0;password=marcocr7000");
        //}

        public Dbcontiner(DbContextOptions<Dbcontiner> opt) : base(opt)
        {

        }


    }
}
