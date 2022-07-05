using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cantinho_Caseiro.Models;

namespace Cantinho_Caseiro.Controllers
{
    public class LoginController : Controller
    {
        private CantinhoCaseiroEntities1 db = new CantinhoCaseiroEntities1();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ValidarLogin(string username = "", string password = "")
        {
            JsonResult result = new JsonResult();
            var credentials = db.Usuarios.Where(model => model.UsrNome == username && model.UsrSenha == password).FirstOrDefault();
          
            if (credentials == null)
            {
                result = this.Json("Login Failed");
                return result;
            }
            else
            {
                result = this.Json("Login Success");
                return result;
            }

        }


    }
}