using Sistema01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sistema01.Controllers
{
    public class UserController : Controller
    {
        private edumatica_dbEntities db = new edumatica_dbEntities();
        // GET: User
        public ActionResult Index()
        {
            ViewBag.nombre = db.employee.First().nombre;
            ViewBag.departamento = db.department.Find(2).descripcion;
            return View();
        }

        public String GetNombre()
        {
            
            return "Alonso";
        }

        public int Suma(int a, int b)
        {
            return a + b;
        }

        public int? GetNumber(int? a)
        {
            return a;
        }

    }
}