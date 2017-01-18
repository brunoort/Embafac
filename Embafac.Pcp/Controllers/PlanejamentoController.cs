using Embafac.Pcp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Embafac.Pcp.Controllers
{
    public class PlanejamentoController : Controller
    {
        // GET: Planejamento
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Create()
        {
            var db = new EmbafacContext("conn");
            ViewBag.Empresa = db.Empresas.ToList();
            ViewBag.Caminhao = db.Caminhoes.ToList();
            return View();
        }

        // POST: Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            var db = new EmbafacContext("conn");

            try
            {
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                return View();
            }
        }
    }
}