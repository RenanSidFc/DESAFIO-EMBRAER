using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DesafioEmbraer.DAL;
using DesafioEmbraer.Models;

namespace DesafioEmbraer.Controllers
{
    public class DESAFIO_EMBRAER_PRODUTOController : Controller
    {
        private LojaContext db = new LojaContext();

        // GET: DESAFIO_EMBRAER_PRODUTO
        public ActionResult Index()
        {
            return View(db.DESAFIO_EMBRAER_PRODUTOS.ToList());
        }

        // GET: DESAFIO_EMBRAER_PRODUTO/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DESAFIO_EMBRAER_PRODUTO dESAFIO_EMBRAER_PRODUTO = db.DESAFIO_EMBRAER_PRODUTOS.Find(id);
            if (dESAFIO_EMBRAER_PRODUTO == null)
            {
                return HttpNotFound();
            }
            return View(dESAFIO_EMBRAER_PRODUTO);
        }

        // GET: DESAFIO_EMBRAER_PRODUTO/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DESAFIO_EMBRAER_PRODUTO/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Produtoid,Nome_prod,Cod_prod,Preco_prod")] DESAFIO_EMBRAER_PRODUTO dESAFIO_EMBRAER_PRODUTO)
        {
            if (ModelState.IsValid)
            {
                db.DESAFIO_EMBRAER_PRODUTOS.Add(dESAFIO_EMBRAER_PRODUTO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dESAFIO_EMBRAER_PRODUTO);
        }

        // GET: DESAFIO_EMBRAER_PRODUTO/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DESAFIO_EMBRAER_PRODUTO dESAFIO_EMBRAER_PRODUTO = db.DESAFIO_EMBRAER_PRODUTOS.Find(id);
            if (dESAFIO_EMBRAER_PRODUTO == null)
            {
                return HttpNotFound();
            }
            return View(dESAFIO_EMBRAER_PRODUTO);
        }

        // POST: DESAFIO_EMBRAER_PRODUTO/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Produtoid,Nome_prod,Cod_prod,Preco_prod")] DESAFIO_EMBRAER_PRODUTO dESAFIO_EMBRAER_PRODUTO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dESAFIO_EMBRAER_PRODUTO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dESAFIO_EMBRAER_PRODUTO);
        }

        // GET: DESAFIO_EMBRAER_PRODUTO/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DESAFIO_EMBRAER_PRODUTO dESAFIO_EMBRAER_PRODUTO = db.DESAFIO_EMBRAER_PRODUTOS.Find(id);
            if (dESAFIO_EMBRAER_PRODUTO == null)
            {
                return HttpNotFound();
            }
            return View(dESAFIO_EMBRAER_PRODUTO);
        }

        // POST: DESAFIO_EMBRAER_PRODUTO/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DESAFIO_EMBRAER_PRODUTO dESAFIO_EMBRAER_PRODUTO = db.DESAFIO_EMBRAER_PRODUTOS.Find(id);
            db.DESAFIO_EMBRAER_PRODUTOS.Remove(dESAFIO_EMBRAER_PRODUTO);
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
