using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ListXampleFromApiRest.API.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<ListXampleFromApiRest.API.Models.Employee> Employees { get; set; }
    }

}

 