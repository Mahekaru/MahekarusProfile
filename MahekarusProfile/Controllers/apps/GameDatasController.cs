using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MahekarusProfile.Models.CRUD;

namespace MahekarusProfile.Controllers.apps
{
    public class GameDatasController : Controller
    {
        private ProfileDBEntities1 db = new ProfileDBEntities1();

        // GET: GameDatas
        public ActionResult Index()
        {
            return View(db.GameDatas.ToList());
        }

        // GET: GameDatas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameData gameData = db.GameDatas.Find(id);
            if (gameData == null)
            {
                return HttpNotFound();
            }
            return View(gameData);
        }

        // GET: GameDatas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GameDatas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,GameName,Description,ReleaseDate")] GameData gameData)
        {
            if (ModelState.IsValid)
            {
                db.GameDatas.Add(gameData);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gameData);
        }

        // GET: GameDatas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameData gameData = db.GameDatas.Find(id);
            if (gameData == null)
            {
                return HttpNotFound();
            }
            return View(gameData);
        }

        // POST: GameDatas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,GameName,Description,ReleaseDate")] GameData gameData)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gameData).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gameData);
        }

        // GET: GameDatas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameData gameData = db.GameDatas.Find(id);
            if (gameData == null)
            {
                return HttpNotFound();
            }
            return View(gameData);
        }

        // POST: GameDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GameData gameData = db.GameDatas.Find(id);
            db.GameDatas.Remove(gameData);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
