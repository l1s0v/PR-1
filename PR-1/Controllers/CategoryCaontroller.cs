using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PR_1.Controllers
{
    public class CategoryCaontroller : Controller
    {
        // GET: CategoryCaontroller
        public ActionResult Index()
        {
            return View();
        }

        // GET: CategoryCaontroller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoryCaontroller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryCaontroller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryCaontroller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoryCaontroller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryCaontroller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoryCaontroller/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
