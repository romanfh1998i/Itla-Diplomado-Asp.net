using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ItlaSigno.Models;

namespace ItlaSigno.Controllers
{
    public class SignoesController : Controller
    {
        private SignoModel db = new SignoModel();

        // GET: Signoes
        public ActionResult Index()
        {
            return View(db.Signoes.ToList());
        }

        // GET: Signoes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Signo signo = db.Signoes.Find(id);
            if (signo == null)
            {
                return HttpNotFound();
            }
            DateTime fecha = signo.Fecha;
            int mes = fecha.Month;
            int dia = fecha.Day;
            string SignoS = "";
            string url = "#";
            switch (mes)
            {
                case 1:
                    if (dia >= 1 && dia <= 20)
                    {
                        SignoS = "Capricornio";
                        url = "/Content/img/capricorn.png";

                    }
                    else if (dia >= 01 && dia <= 20)
                    {
                        SignoS = "Acuario";
                        url = "/Content/img/aquarius.png";
                    }
                    break;
                case 2:
                    if (dia >= 1 && dia <= 19)
                    {
                        SignoS = "Acuario";
                        url = "/Content/img/aquarius.png";

                    }
                    else if (dia >= 20 && dia <= 29)
                    {
                        SignoS = "Piscis";
                        url = "/Content/img/pisces.png";

                    }
                    break;
                case 3:
                    if (dia >= 1 && dia <= 20)
                    {
                        SignoS = "Piscis";
                        url = "/Content/img/pisces.png";

                    }
                    else if (dia >= 21 && dia <= 31)
                    {
                        SignoS = "Aries";
                        url = "/Content/img/aries.png";
                    }
                    break;
                case 4:
                    if (dia >= 1 && dia <= 20)
                    {
                        SignoS = "Aries";
                        url = "/Content/img/aries.png";

                    }
                    else if (dia >= 21 && dia <= 30)
                    {
                        SignoS = "Tauro";
                        url = "/Content/img/taurus.png";
                    }
                    break;
                case 5:
                    if (dia >= 1 && dia <= 21)
                    {
                        SignoS = "Tauro";
                        url = "/Content/img/taurus.png";

                    }
                    else if (dia >= 22 && dia <= 31)
                    {
                        SignoS = "Geminis";
                        url = "/Content/img/gemini.png";
                    }
                    break;
                case 6:
                    if (dia >= 1 && dia <= 21)
                    {
                        SignoS = "Geminis";
                        url = "/Content/img/gemini.png";

                    }
                    else if (dia >= 22 && dia <= 30)
                    {
                        SignoS = "Cancer";
                        url = "/Content/img/cancer.png";
                    }
                    break;
                case 7:
                    if (dia >= 1 && dia <= 22)
                    {
                        SignoS = "Cancer";
                        url = "/Content/img/cancer.png";

                    }
                    else if (dia >= 23 && dia <= 31)
                    {
                        SignoS = "Leo";
                        url = "/Content/img/leo.png";
                    }
                    break;
                case 8:
                    if (dia >= 1 && dia <= 22)
                    {
                        SignoS = "Leo";
                        url = "/Content/img/leo.png";

                    }
                    else if (dia >= 23 && dia <= 31)
                    {
                        SignoS = "Virgo";
                        url = "/Content/img/virgo.png";
                    }
                    break;
                case 9:
                    if (dia >= 1 && dia <= 22)
                    {
                        SignoS = "Virgo";
                        url = "/Content/img/virgo.png";

                    }
                    else if (dia >= 23 && dia <= 30)
                    {
                        SignoS = "Libra";
                        url = "/Content/img/libra.png";
                    }
                    break;
                case 10:
                    if (dia >= 1 && dia <= 22)
                    {
                        SignoS = "Libra";
                        url = "/Content/img/libra.png";

                    }
                    else if (dia >= 23 && dia <= 31)
                    {
                        SignoS = "Escorpion";
                        url = "/Content/img/scorpio.png";
                    }
                    break;
                case 11:
                    if (dia >= 1 && dia <= 22)
                    {
                        SignoS = "Escorpion";
                        url = "/Content/img/scorpio.png";

                    }
                    else if (dia >= 23 && dia <= 30)
                    {
                        SignoS = "Sagitario";
                        url = "/Content/img/sagittarius.png";
                    }
                    break;
                case 12:
                    if (dia >= 1 && dia <= 22)
                    {
                        SignoS = "Sagitario";
                        url = "/Content/img/sagittarius.png";

                    }
                    else if (dia >= 23 && dia <= 31)
                    {
                        SignoS = "Capricornio";
                        url = "/Content/img/capricorn.png";
                    }
                    break;

            }

            ViewBag.SignoS = SignoS;
            ViewBag.url = url;
            return View(signo);
        }

        // GET: Signoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Signoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UsuarioId,UsuarioNombre,UsuarioApellido,UsuarioCedula,Fecha")] Signo signo)
        {
            if (ModelState.IsValid)
            {
                db.Signoes.Add(signo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(signo);
        }

        // GET: Signoes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Signo signo = db.Signoes.Find(id);
            if (signo == null)
            {
                return HttpNotFound();
            }
              
                return View(signo);
            }
        

        // POST: Signoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UsuarioId,UsuarioNombre,UsuarioApellido,UsuarioCedula,Fecha")] Signo signo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(signo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(signo);
        }

        // GET: Signoes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Signo signo = db.Signoes.Find(id);
            if (signo == null)
            {
                return HttpNotFound();
            }
            return View(signo);
        }

        // POST: Signoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Signo signo = db.Signoes.Find(id);
            db.Signoes.Remove(signo);
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
