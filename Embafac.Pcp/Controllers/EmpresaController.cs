using Embafac.Pcp.Entidades;
using Embafac.Pcp.Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Embafac.Pcp.Controllers
{
    public class EmpresaController : Controller
    {
        // GET: Empresa
        public ActionResult Index()
        {
            var db = new EmbafacContext("conn");
            ViewBag.Empresa = db.Empresas.ToList();

            return View();
        }

        // GET: Empresa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empresa/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            var db = new EmbafacContext("conn");

            try
            {
                Empresa empresa = new Empresa
                {
                    Nome = collection["Nome"],
                    Endereco = collection["Endereco"]
                };

                db.Empresas.Add(empresa);
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

        // GET: Empresa/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Empresa/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Empresa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Empresa/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
