using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Register.Models;

namespace Register.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions <AppDbContext> Options): base(Options)
        {

        }
        public virtual DbSet<Register>Registers{get;set;}
    }
}