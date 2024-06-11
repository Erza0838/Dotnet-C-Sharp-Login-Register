using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoginRegister.Controllers
{
    public class CreateNewAccountController : Controller
    {
        // GET: CreateNewAccountController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CreateNewAccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CreateNewAccountController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CreateNewAccountController/Create
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

        // GET: CreateNewAccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CreateNewAccountController/Edit/5
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

        // GET: CreateNewAccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CreateNewAccountController/Delete/5
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
