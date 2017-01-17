using Embafac.Pcp.Entidades;
using Embafac.Pcp.Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Embafac.Pcp.Controllers
{
    public class TipoVeiculoController : Controller
    {
        // GET: TipoVeiculo
        public ActionResult Index()
        {
            var db = new EmbafacContext("conn");

            ViewBag.TipoVeiculo = db.TipoVeiculos.ToList();
            return View();
        }

        // GET: TipoVeiculo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoVeiculo/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            var db = new EmbafacContext("conn");

            try
            {
                TipoVeiculo tipoVeiculo = new TipoVeiculo
                {
                    Descricao = collection["Descricao"]
                };

                db.TipoVeiculos.Add(tipoVeiculo);
                db.SaveChanges();

                // TODO: Add insert logic here
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                return View();
            }
        }

        // GET: TipoVeiculo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }


        // GET: TipoVeiculo/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                var db = new EmbafacContext("conn");
                var tipoVeiculo = db.TipoVeiculos.Where(x => x.Id == id).FirstOrDefault();

                db.TipoVeiculos.Remove(tipoVeiculo);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}
