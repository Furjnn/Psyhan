using Dataaccess.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataaccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base(ConfigurationManager.ConnectionStrings["DatabaseContext"].ConnectionString)
        {
            
        }

        public DbSet<User> Users { get; set; }
    }

}
