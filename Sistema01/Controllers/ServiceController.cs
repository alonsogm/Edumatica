using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sistema01.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        public String Index(String department_id)
        {
            proveedors.WebService1 proveedorx = new proveedors.WebService1();

            String empleados = proveedorx.GetEmployee(department_id);
            
            return empleados;
        }


     
        public ActionResult GetViewEmp()
        {
            return View();
        }

        public String cantidadEmpleados()
        {
            proveedors.WebService1 proveedorCantidad = new proveedors.WebService1();
            String cantidad = proveedorCantidad.CantidadEmpleados();
            return cantidad;
        }

        public String DataG() {
            proveedors.WebService1 proveedorCantidad = new proveedors.WebService1();
            String data = proveedorCantidad.GetData();
            return data;

        }

        public ActionResult DownloadViewPDF()
        {
            return new Rotativa.MVC.ActionAsPdf("/GetViewEmp") { FileName = "Reporte.pdf" };
        }
    }
}