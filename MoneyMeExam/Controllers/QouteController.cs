using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoneyMeExam.Models;

namespace MoneyMeExam.Controllers
{
    public class QouteController : Controller
    {
        private readonly moneymedbContext _context;

        public QouteController(moneymedbContext context) 
        { 
            _context = context; 
        }

        [HttpGet]
        public async Task<IActionResult> SaveQoute(TblQoute model)
        {
            //For testing purpose
            if (model == null)
            {
                model = new TblQoute()
                {
                    AmountRquired = 5000,
                    Term = 2,
                    Title = "Mr.",
                    FirstName = "John",
                    LastName = "doe",
                    DateOfBirth = new DateTime(1900, 1, 1),
                    Mobile = "0422111333",
                    Email = "layton@flower.com.au"
                };
            }

            TblQoute currenrQoute;

            //Checking if the first name, last name and birthday already exist in the database
            if (_context.TblQoutes.Any(x => x.FirstName == model.FirstName &&
                                         x.LastName == model.LastName &&
                                         x.DateOfBirth == model.DateOfBirth))
            {
                currenrQoute = _context.TblQoutes.Where(x => x.FirstName == model.FirstName &&
                                         x.LastName == model.LastName &&
                                         x.DateOfBirth == model.DateOfBirth).First();
            }
            else
            {
                _context.TblQoutes.Add(model);
                await _context.SaveChangesAsync();

                currenrQoute = model;
            }

            return RedirectToAction("Create", currenrQoute);
        }


        [HttpGet]
        public async Task<IActionResult> Create(TblQouteViewModel model)
        { 

            return View(model); 
        }


        [HttpPost] 
        public async Task<IActionResult> CreateAsync(TblQouteViewModel model)
        {


            return RedirectToAction("FinalQoute", model);
        }


        [HttpGet]
        public async Task<IActionResult> FinalQoute(TblQouteViewModel model)
        {

            return View(model);
        }
    }
}
