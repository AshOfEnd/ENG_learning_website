using CMS.Helpers;
using ENG_learning_website.Data;
using ENG_learning_website.Models;
using Microsoft.AspNetCore.Mvc;
using Stripe;

namespace ENG_learning_website.Controllers
{
    public class CheckOutController : Controller
    {
        private readonly IDBContext _idbContext;

        private readonly DBContext _dbContext;
        public CheckOutController(IDBContext idbContext, DBContext dbContext)
        {
          
            _idbContext = idbContext;
            _dbContext = dbContext;

        }
        [TempData]
        public string TotalAmmount { get; set; }
        public IActionResult Index()
        {
            var cos = HttpContext.User.Identity.Name;
            ViewBag.Clients = _dbContext.Clients.Where(x => x.Name == cos).FirstOrDefault();
            return View();
        }

        [HttpPost]
        public IActionResult Processing(string StripeToken, string StripeEmail)
        {
            var optionCust = new CustomerCreateOptions
            {
                Email = StripeEmail,
                Name = "Gierczak",
                Phone = "48666666",

            };
            var serviceCust = new CustomerService();
            Customer customer = serviceCust.Create(optionCust);
            var optionCharge = new ChargeCreateOptions()
            {
                Amount =100,
                Currency ="NZD",
                Description = "Subscription",
                Source = StripeToken,
                ReceiptEmail = StripeEmail,
            };
            var ServiceCharge=new ChargeService();
           
                Charge charge = ServiceCharge.Create(optionCharge);
          
         
            if(charge.Status =="succeeded")
            {
                ViewBag.AmountPaid = Convert.ToDecimal(charge.Amount) % 100 / 100 + (charge.Amount) / 100;
                ViewBag.Customer = customer.Name;
                //var temp = User.Identity.Name;
                //var baza = _dbContext.Users.Where(x => x.UserName == temp).Select(x=>x.Email);
                   var cos=HttpContext.User.Identity.Name;
              
                var temp=_dbContext.Clients.Where(x=>x.Name==cos).FirstOrDefault();
                if (temp == null) 
                {
                    Client client = new Client()
                    {
                        Name = cos.ToString(),
                        subscription = true,
                        points = 0,
                    };
                        _dbContext.Clients.Add(client);

                    //   temp.Subscription = true;
                    _dbContext.SaveChanges();
                }
                else
                {
                    Console.WriteLine("UZYTKOWNIK POSIADA JUZ SUBSKRYPCJE");
                }
                    ViewBag.Clients = _dbContext.Clients.Where(x => x.Name == cos).FirstOrDefault();
            }
            if(charge.Status =="failed")
            {
                
                return View(ViewBag.Status = charge.Status);
            }
            if (charge.Status == "pending")
            {

                return View(ViewBag.Status = charge.Status);
            }
            return View();
        }
    }
}
