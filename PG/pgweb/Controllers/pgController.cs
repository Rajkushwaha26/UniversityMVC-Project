using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using pgweb.Models;

namespace pgweb.Controllers
{
   
    public class pgController : Controller
    {
        private readonly ApplicationDbContext db;
        public pgController(ApplicationDbContext context){
            this.db=context;
        }

 

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}