using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoAjaxCallController.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoAjaxCallController.Controllers
{
    public class CodegymController : Controller
    {
        private readonly AppDbContext _dbContext;

        public CodegymController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult List()
        {
            
            return View(_dbContext.Codegymers.ToList());
        }

        [HttpPost]
        public Codegymer List(int id, string attr)
        {
            var codegymer = _dbContext.Codegymers.Find(id);

            switch (attr)
            {
                case "IsDepTrai":
                    codegymer.IsDepTrai = !codegymer.IsDepTrai;
                    break;
                case "IsGiau":
                    codegymer.IsGiau = !codegymer.IsGiau;
                    break;
                case "IsThongMinh":
                    codegymer.IsThongMinh = !codegymer.IsThongMinh;
                    break;                    
            }
            _dbContext.SaveChanges();

            return codegymer;
        }
    }
}