using Padmate.Allen.Models;
using Padmate.Allen.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Padmate.Allen.Controllers
{
    public class SingerController:Controller
    {
        SingerService singerService = new SingerService();
        public ActionResult Index()
        {
            List<Singer> singers = singerService.SearchAll();
            return View(singers);
        }

        public ActionResult Details(int id = 0)
        {
            Singer singer = singerService.SearchById(id);
            if (singer == null)
            {
                return HttpNotFound();
            }
            return View(singer);
        }

        //
        // GET: /Home/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Home/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Singer singer)
        {
            if (ModelState.IsValid)
            {
                singerService.Add(singer);
                return RedirectToAction("Index");
            }

            return View(singer);
        }

        //
        // GET: /Home/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Singer singer = singerService.SearchById(id);
            if (singer == null)
            {
                return HttpNotFound();
            }
            return View(singer);
        }

        //
        // POST: /Home/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Singer singer)
        {
            if (ModelState.IsValid)
            {
                singerService.Edit(singer);
                return RedirectToAction("Index");
            }
            return View(singer);
        }

        //
        // GET: /Home/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Singer singer = singerService.SearchById(id);
            if (singer == null)
            {
                return HttpNotFound();
            }
            return View(singer);
        }

        //
        // POST: /Home/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            singerService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
