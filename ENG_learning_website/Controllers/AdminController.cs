using ENG_learning_website.Data;
using ENG_learning_website.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net;

namespace ENG_learning_website.Controllers
{
    public class AdminController : Controller
    {
        private readonly DBContext _dbcontext;
        private readonly IDBContext _idbcontext;
        public AdminController(DBContext context,IDBContext icontext)
        {
            _dbcontext = context;
            _idbcontext = icontext;
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            var result = _dbcontext.Client.ToList();
            return View(result);
        }
        public  IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dictionary =  _dbcontext.Client
                .Find(id);
            if (dictionary == null)
            {
                return NotFound();
            }

            return View(dictionary);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Registered = new SelectList(_idbcontext.Users.Select(x=>x.UserName));

            return View();
        }
        [HttpPost]
        public IActionResult Create(Client client)
        {

            var result = _dbcontext.Add(client);
            _dbcontext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public  IActionResult Delete(int? id)
        {
            if (id == null)
            {
             
            }

            var client =  _dbcontext.Client
                .Find(id);
            if (client == null)
            {
               
            }

            return View(client);
        }

        // POST: Dictionaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public  IActionResult DeleteConfirmed(int? id)
        {
            var dictionary =  _dbcontext.Client.FirstOrDefault(x=>x.ClientId==id);
            _dbcontext.Client.Remove(dictionary);
            _dbcontext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
