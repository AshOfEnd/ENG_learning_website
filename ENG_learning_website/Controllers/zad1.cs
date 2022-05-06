using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ENG_learning_website.Data;
using ENG_learning_website.Models;

namespace ENG_learning_website.Controllers
{

    public class zad1 : Controller
    {
        private readonly DBContext _context;

        public zad1(DBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

           
            
            return View();
        }
              
    }
}
