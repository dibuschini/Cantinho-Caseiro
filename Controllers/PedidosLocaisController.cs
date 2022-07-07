using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Cantinho_Caseiro.Models;

namespace Cantinho_Caseiro.Controllers
{
    public class PedidosLocaisController : Controller
    {
        private CantinhoCaseiroEntities1 db = new CantinhoCaseiroEntities1();

        // GET: PedidosLocais
        public ActionResult Index()
        {
            return View(db.PedidosLocais.ToList());
        }

        // GET: PedidosLocais/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PedidosLocais pedidosLocais = db.PedidosLocais.Find(id);
            if (pedidosLocais == null)
            {
                return HttpNotFound();
            }
            return View(pedidosLocais);
        }

        // GET: PedidosLocais/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PedidosLocais/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,PdcPrato,PdcQuantidade,PdcCliente,PdcData,PdcAdcional")] PedidosLocais pedidosLocais)
        {
            if (ModelState.IsValid)
            {
                db.PedidosLocais.Add(pedidosLocais);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pedidosLocais);
        }

        // GET: PedidosLocais/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PedidosLocais pedidosLocais = db.PedidosLocais.Find(id);
            if (pedidosLocais == null)
            {
                return HttpNotFound();
            }
            return View(pedidosLocais);
        }

        // POST: PedidosLocais/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,PdcPrato,PdcQuantidade,PdcCliente,PdcData,PdcAdcional")] PedidosLocais pedidosLocais)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pedidosLocais).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pedidosLocais);
        }

        // GET: PedidosLocais/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PedidosLocais pedidosLocais = db.PedidosLocais.Find(id);
            if (pedidosLocais == null)
            {
                return HttpNotFound();
            }
            return View(pedidosLocais);
        }

        // POST: PedidosLocais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PedidosLocais pedidosLocais = db.PedidosLocais.Find(id);
            db.PedidosLocais.Remove(pedidosLocais);
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
