using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using pgweb.Models;

namespace pgweb.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> Options):base(Options)
        {

        }
        public DbSet<pg>pgs {set;get;}
        
    }
}