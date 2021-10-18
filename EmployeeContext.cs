using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace MachineTest.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext():base("Constr")
        {
          

        }
        public DbSet<EmployeeModel> EmployeeModels { get; set; }


    }
}