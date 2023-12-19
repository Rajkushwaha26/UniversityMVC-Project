using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pgweb.Models
{
    public class ApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> Options):base(Options){

        }
    }
}