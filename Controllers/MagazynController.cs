using Microsoft.AspNetCore.Mvc;
using LAB2.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LAB2.Controllers
{
    public class MagazynController : Controller
    {
        private static IList<Magazyn> products = new List<Magazyn>()
        {
            new Magazyn(){Id = 1, Produkt = "Koszulka" , Cena = 99, Ilosc = 10}
        };



        // GET: FilmController
        public ActionResult Index()
        {
            return View(products);
        }

        // GET: FilmController/Details/5
        public ActionResult Details(int id)
        {
            return View(products.FirstOrDefault(x => x.Id == id));
        }

        // GET: FilmController/Create

        public ActionResult Create()
        {
            return View();
        }

        // POST: FilmController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Magazyn product)
        {
            product.Id = products.Count + 1;
            products.Add(product);
            return RedirectToAction("Index");

        }

        // GET: FilmController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(products.FirstOrDefault(x => x.Id == id));
        }

        // POST: FilmController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Magazyn product)
        {
            Magazyn product1 = products.FirstOrDefault(x => x.Id == id);
            product1.Produkt = product.Produkt;
            product1.Cena = product.Cena;
            product1.Ilosc = product.Ilosc;

            return RedirectToAction("Index");
        }

        // GET: FilmController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(products.FirstOrDefault(x => x.Id == id));
        }

        // POST: FilmController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Magazyn product)
        {
            Magazyn product1 = products.FirstOrDefault(x => x.Id == id);
            products.Remove(product1);

            return RedirectToAction("Index");

        }
    }
}