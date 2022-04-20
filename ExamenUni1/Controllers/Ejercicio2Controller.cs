using ExamenUni1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenUni1.Controllers
{
    public class Ejercicio2Controller : Controller
    {
        // GET: Ejercicio2

        public static List<ClsEstudiante> listaEstudiantes = new List<ClsEstudiante>
        {
            new ClsEstudiante(){codigo="20145454",nombres="estudiante1",apellidos="apellido1",curso="programcion 1",notaexamen=11,notalaboratorio=17,notaproyecto=15,notaactitudinal=1},
            new ClsEstudiante(){codigo="20145455",nombres="estudiante2",apellidos="apellido2",curso="programcion 2",notaexamen=10,notalaboratorio=16,notaproyecto=14,notaactitudinal=2},
            new ClsEstudiante(){codigo="20145456",nombres="estudiante3",apellidos="apellido3",curso="programcion 3",notaexamen=19,notalaboratorio=15,notaproyecto=13,notaactitudinal=3},
            new ClsEstudiante(){codigo="20145457",nombres="estudiante4",apellidos="apellido4",curso="programcion 4",notaexamen=8,notalaboratorio=14,notaproyecto=12,notaactitudinal=4},
            new ClsEstudiante(){codigo="20145458",nombres="estudiante5",apellidos="apellido5",curso="programcion 5",notaexamen=7,notalaboratorio=13,notaproyecto=10,notaactitudinal=5},
            new ClsEstudiante(){codigo="20145459",nombres="estudiante6",apellidos="apellido6",curso="programcion 6",notaexamen=6,notalaboratorio=12,notaproyecto=9,notaactitudinal=6},
            new ClsEstudiante(){codigo="20145450",nombres="estudiante7",apellidos="apellido7",curso="programcion 7",notaexamen=5,notalaboratorio=11,notaproyecto=8,notaactitudinal=7},
            new ClsEstudiante(){codigo="20145451",nombres="estudiante8",apellidos="apellido8",curso="programcion 8",notaexamen=4,notalaboratorio=10,notaproyecto=7,notaactitudinal=8},
      
        };

        public ActionResult Index()
        {
            ViewModel model = new ViewModel();
            foreach (var item in listaEstudiantes)
            {
                item.promedio = (item.notaexamen * 0.40) + (item.notalaboratorio*0.30)+(item.notaproyecto*0.25)+(item.notaactitudinal*0.05);
                if (item.promedio>=0 && item.promedio<10.5)
                {
                    item.condicion = "Desaprobado";
                    item.color = "btn btn-danger";
                }
                if (item.promedio>=10.5 && item.promedio<=20)
                {
                    item.condicion = "Aprobado";
                    item.color = "btn btn-primary";
                }
            }

            int cantidadAprobados = listaEstudiantes.Where(x => x.condicion == "Aprobado").Count();
            int cantidadDesaAprobados = listaEstudiantes.Where(x => x.condicion == "Desaprobado").Count();
            double promax = listaEstudiantes.Max(x => x.promedio);
            double promin = listaEstudiantes.Min(x => x.promedio);
            double promedioNotas = listaEstudiantes.Sum(x => x.promedio) / listaEstudiantes.Count();
            model.cantidadAprobados = cantidadAprobados;
            model.cantidadDesaAprobados = cantidadDesaAprobados;
            model.promax = promax;
            model.promin = promin;
            model.lista = listaEstudiantes;
            model.promedioNotas = promedioNotas;
            return View(model);
        }
    }
}