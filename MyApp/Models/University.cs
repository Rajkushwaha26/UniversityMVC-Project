using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class University
    {
        public int Id { get; set; }
        public string? RegNo { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }
        public string? FamousCourse { get; set; }
    }
}