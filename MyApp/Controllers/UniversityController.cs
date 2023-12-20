using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Controllers
{
    
    public class UniversityController : Controller
    {
        private readonly ApplicationDbContext db;
        public UniversityController(ApplicationDbContext context){
            this.db=context;
        }


        public IActionResult Index()
        {
            var emplist = db.Universitys;
            return View(emplist);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(University U){
            db.Universitys.Add(U);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id){
            var unilist=db.Universitys.Find(id);
            if(unilist!=null){
                db.Universitys.Remove(unilist);
                db.SaveChanges();
                return RedirectToAction("Index");
            }else{
                return View();
            }
            
        }

        public IActionResult Edit(int id){
            var emp = db.Universitys.FirstOrDefault(e=>e.Id==id);
            if(emp!=null){
                return View(emp);
            }else{
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Edit(University newObj){
            db.Update(newObj);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}