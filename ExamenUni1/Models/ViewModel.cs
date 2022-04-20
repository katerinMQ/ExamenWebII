using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenUni1.Models
{
    public class ViewModel
    {
        public double promax { get; set; }
        public double promin { get; set; }
        public double promedioNotas { get; set; }
        public int cantidadAprobados { get; set; }
        public int cantidadDesaAprobados { get; set; }
        public List<ClsEstudiante> lista { get; set; }


    }
}