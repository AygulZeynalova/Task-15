using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task15.Models.Contexts;
using Task15.Models.Entities;

namespace Task15.Controllers
{
    public class CountriesController : Controller
    {
        private readonly DataContext db;

        public CountriesController(DataContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var countries = db.Countries.ToList();

            return View(countries);
        }

        public IActionResult Details(int id)
        {
            var country = db.Countries.Where(m => m.Id == id).FirstOrDefault();

            return View(country);
        }

        public IActionResult Edit()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Edit(Country model)
        {
            db.Entry(model).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Country model)
        {
            db.Countries.Add(model);
            db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Remove(int id)
        {
            var country = db.Countries.Where(m => m.Id == id).FirstOrDefault();


            db.Countries.Remove(country);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
