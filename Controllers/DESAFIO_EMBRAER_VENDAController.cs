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
    public class DESAFIO_EMBRAER_VENDAController : Controller
    {
        private LojaContext db = new LojaContext();

        // GET: DESAFIO_EMBRAER_VENDA
        public ActionResult Index()
        {
            return View(db.DESAFIO_EMBRAER_VENDAS.ToList());
        }

        // GET: DESAFIO_EMBRAER_VENDA/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DESAFIO_EMBRAER_VENDA dESAFIO_EMBRAER_VENDA = db.DESAFIO_EMBRAER_VENDAS.Find(id);
            if (dESAFIO_EMBRAER_VENDA == null)
            {
                return HttpNotFound();
            }
            return View(dESAFIO_EMBRAER_VENDA);
        }

        // GET: DESAFIO_EMBRAER_VENDA/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DESAFIO_EMBRAER_VENDA/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Vendaid,Cod_prod,Vendedor,Valor_unit,Quantidade,Valor_total,Data")] DESAFIO_EMBRAER_VENDA dESAFIO_EMBRAER_VENDA)
        {
            if (ModelState.IsValid)
            {
                db.DESAFIO_EMBRAER_VENDAS.Add(dESAFIO_EMBRAER_VENDA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dESAFIO_EMBRAER_VENDA);
        }

        // GET: DESAFIO_EMBRAER_VENDA/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DESAFIO_EMBRAER_VENDA dESAFIO_EMBRAER_VENDA = db.DESAFIO_EMBRAER_VENDAS.Find(id);
            if (dESAFIO_EMBRAER_VENDA == null)
            {
                return HttpNotFound();
            }
            return View(dESAFIO_EMBRAER_VENDA);
        }

        // POST: DESAFIO_EMBRAER_VENDA/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Vendaid,Cod_prod,Vendedor,Valor_unit,Quantidade,Valor_total,Data")] DESAFIO_EMBRAER_VENDA dESAFIO_EMBRAER_VENDA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dESAFIO_EMBRAER_VENDA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dESAFIO_EMBRAER_VENDA);
        }

        // GET: DESAFIO_EMBRAER_VENDA/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DESAFIO_EMBRAER_VENDA dESAFIO_EMBRAER_VENDA = db.DESAFIO_EMBRAER_VENDAS.Find(id);
            if (dESAFIO_EMBRAER_VENDA == null)
            {
                return HttpNotFound();
            }
            return View(dESAFIO_EMBRAER_VENDA);
        }

        // POST: DESAFIO_EMBRAER_VENDA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DESAFIO_EMBRAER_VENDA dESAFIO_EMBRAER_VENDA = db.DESAFIO_EMBRAER_VENDAS.Find(id);
            db.DESAFIO_EMBRAER_VENDAS.Remove(dESAFIO_EMBRAER_VENDA);
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
