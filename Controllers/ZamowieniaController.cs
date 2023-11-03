using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LAB2.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LAB2.Controllers
{
    public class ZamowieniaController : Controller
    {
        private static IList<Zamowienia> orders = new List<Zamowienia>()
        {
                 new Zamowienia(){Id = 1, Produkt = "Koszulka", Data = DateTime.Now, WartoscZamowienia = 99, StatusZamowienia = "W realizacji"}
        };


        // GET: FilmController
        public ActionResult Index()
        {
            return View(orders);
        }

        // GET: FilmController/Details/5
        public ActionResult Details(int id)
        {
            return View(orders.FirstOrDefault(x => x.Id == id));
        }

        // GET: FilmController/Create

        public ActionResult Create()
        {
            ViewBag.StatusyZamowienia = new List<SelectListItem>
        {
            new SelectListItem { Value = "W realizacji", Text = "W realizacji" },
            new SelectListItem { Value = "Odebrany przez klienta", Text = "Odebrany przez klienta" }
        };

            return View();
        }

        // POST: FilmController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Zamowienia order)
        {
            order.Id = orders.Count + 1;
            orders.Add(order);
            return RedirectToAction("Index");

        }

        // GET: FilmController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.StatusyZamowienia = new List<SelectListItem>
        {
            new SelectListItem { Value = "W realizacji", Text = "W realizacji" },
            new SelectListItem { Value = "Odebrany przez klienta", Text = "Odebrany przez klienta" }
        };
            return View(orders.FirstOrDefault(x => x.Id == id));
        }

        // POST: FilmController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Zamowienia order)
        {
            Zamowienia order1 = orders.FirstOrDefault(x => x.Id == id);
            order1.Produkt = order.Produkt;
            order1.WartoscZamowienia = order.WartoscZamowienia;
            order1.StatusZamowienia = order.StatusZamowienia;

            return RedirectToAction("Index");
        }

        // GET: FilmController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(orders.FirstOrDefault(x => x.Id == id));
        }

        // POST: FilmController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Zamowienia order)
        {
            Zamowienia order1 = orders.FirstOrDefault(x => x.Id == id);
            orders.Remove(order1);

            return RedirectToAction("Index");

        }
    }
}