

using Embafac.Pcp.Entidades;
using Embafac.Pcp.Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Embafac.Pcp.Controllers
{

    public class CaminhaoController : Controller
    {
        
        // GET: Caminhao
        public ActionResult Index()
        {
            var db = new EmbafacContext("conn");
            ViewBag.Caminhoes = db.Caminhoes.ToList();
            ViewBag.TipoVeiculo = db.TipoVeiculos.ToList();

            return View();
        }
        
        // GET: Caminhao/Create
        public ActionResult Create()
        {
            var db = new EmbafacContext("conn");
            ViewBag.TipoVeiculo = db.TipoVeiculos.ToList();

            return View();
        }

        // POST: Caminhao/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            var db = new EmbafacContext("conn");

            try
            {
                var IdTipoVeiculo = Convert.ToInt32(collection["ddlTipoVeiculo"]);
                TipoVeiculo tipoVeiculo = db.TipoVeiculos.Where(x => x.Id == IdTipoVeiculo).FirstOrDefault();

                Caminhao caminhao = new Caminhao
                {
                    Placa = collection["Placa"],
                    TipoVeiculo = tipoVeiculo,
                    CapacidadeEntregaTamborEmPe = Convert.ToInt32(collection["CapacidadeEntregaTamborEmPe"]),
                    CapacidadeEntregaTamborAltoDeitado = Convert.ToInt32(collection["CapacidadeEntregaTamborAltoDeitado"]),
                    CapacidadeEntregaTamborBaixoDeitado = Convert.ToInt32(collection["CapacidadeEntregaTamborBaixoDeitado"]),
                    CapacidadeColetaTamborEmPe = Convert.ToInt32(collection["CapacidadeColetaTamborEmPe"]),
                    CapacidadeColetaTamborAltoDeitado = Convert.ToInt32(collection["CapacidadeColetaTamborAltoDeitado"]),
                    CapacidadeColetaTamborBaixoDeitado = Convert.ToInt32(collection["CapacidadeColetaTamborBaixoDeitado"])
                };

                db.Caminhoes.Add(caminhao);
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
        
        // GET: Caminhao/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                var db = new EmbafacContext("conn");
                var caminhao = db.Caminhoes.Where(x => x.Id == id).FirstOrDefault();

                db.Caminhoes.Remove(caminhao);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        // GET: Caminhao/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }


    }
}
