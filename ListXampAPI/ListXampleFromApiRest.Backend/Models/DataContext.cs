using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ListXampleFromApiRest.Backend.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<ListXampleFromApiRest.Backend.Models.Employee> Employees { get; set; }
    }

}