using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BLL;

{

}

namespace _3tier.Pages.controller
{
    public class studentController : Controller

    {
        
        // GET: studentController
        public ActionResult index()
        {
            studentRepository studentRepo = new studentRepository();
            string data = studentRepo.GetStudent();


            return View();
            
        }

        // GET: studentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: studentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: studentController/Create
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

        // GET: studentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: studentController/Edit/5
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

        // GET: studentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: studentController/Delete/5
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
