using JSoft.ControlHorarios.Data;
using JSoft.ControlHorarios.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JSoft.ControlHorarios.WebApp.Controllers
{
    public class ReportController : Controller
    {
        // GET: Report/IOEmpleado
        public ActionResult IOEmpleado()
        {
            var modelo = new EntradaSalidaModel();
            modelo.FechaDesde = DateTime.Now;
            modelo.FechaHasta = DateTime.Now;
            modelo.ReportData = new List<CH_RPT_ENTRADA_SALIDA_POR_EMPLEADO_Result>();
            return View(modelo);
        }

        // POST: Report/Generate
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Generate(EntradaSalidaModel modelo)
        {
            Factory factory = new Factory();
            modelo.ReportData = factory.GenerarReporteEntradaSalida(modelo.FechaDesde, modelo.FechaHasta);
            return View("IOEmpleado", modelo);
        }
    }
}