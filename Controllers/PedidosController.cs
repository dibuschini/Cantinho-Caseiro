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
    public class PedidosController : Controller
    {
        private CantinhoCaseiroEntities1 db = new CantinhoCaseiroEntities1();
        // GET: Pedidos
        public ActionResult Pedido()
        {
            return View();
        }

        public ActionResult Criar_Pedido([Bind(Include = "id,PdcPrato,PdcQuantidade,PdcCliente,PdcData,PdcAdcional")] PedidosLocais pedidos)
        {

            if (ModelState.IsValid)
            {
                db.PedidosLocais.Add(pedidos);
                db.SaveChanges();


                return Redirect("https://localhost:44317/Pedidos/Pedido");
            }

            return View(pedidos);
        }
    }
}