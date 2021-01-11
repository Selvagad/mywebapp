using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapp.Models
{
    public class webappContext : DbContext
    {

        public webappContext(DbContextOptions<webappContext> options)
            :base(options)
        {

        }
      

        public virtual DbSet<Person> Persons { get; set; }
    }

}
