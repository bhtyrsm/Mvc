using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ActionFilters.Models
{
    public class DataBaseContext:DbContext
    {
        public DbSet<Log> Logs { get; set; }
        public DbSet<SiteUser> SiteUsers { get; set; }
    }
}