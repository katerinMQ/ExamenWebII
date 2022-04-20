using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenUni1.Controllers
{
    public class Ejercicio1Controller : Controller
    {
        // GET: Ejercicio1
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult calcular()
        {
           

            int edad = int.Parse( Request["edad"]);
            int precio =int.Parse(  Request["precio"]);
            string dia = Request["cbodias"];
            if (dia== "Martes" && edad >=30  && edad <=60)
            {
                var porce = precio * 0.25;
                var result = precio - porce;

                ViewBag.Precio = precio;
                ViewBag.edad = edad;
                ViewBag.dia = dia;
                ViewBag.desceunto = "25%";
                ViewBag.total = result;
                return View("Index");

            }
            if (dia == "Lunes" && edad <18)
            {
                var porce = precio * 0.20;
                var result = precio - porce;

                ViewBag.Precio = precio;
                ViewBag.edad = edad;
                ViewBag.dia = dia;
                ViewBag.desceunto = "20%";
                ViewBag.total = result;
                return View("Index");
            }
            if (dia == "Miercoles" && edad > 60)
            {
                var porce = precio * 0.40;
                var result = precio - porce;

                ViewBag.Precio = precio;
                ViewBag.edad = edad;
                ViewBag.dia = dia;
                ViewBag.desceunto = "40%";
                ViewBag.total = result;
                return View("Index");
            }
            if (dia == "jueves" && edad > 60)
            {
                var porce = precio * 0.10;
                var result = precio - porce;

                ViewBag.Precio = precio;
                ViewBag.edad = edad;
                ViewBag.dia = dia;
                ViewBag.desceunto = "10%";
                ViewBag.total = result;
                return View("Index");
            }
            var porce2 = precio * 0.10;
            var result2 = precio - porce2;
            ViewBag.Precio = precio;
            ViewBag.edad = edad;
            ViewBag.dia = dia;
            ViewBag.desceunto = "10%";
            ViewBag.total = result2;
            return View("Index");

         
        }

    }
}