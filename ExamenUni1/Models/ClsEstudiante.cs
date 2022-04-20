using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenUni1.Models
{
    public class ClsEstudiante
    {
        public string codigo { get; set; }
        public string apellidos { get; set; }
        public string nombres { get; set; }
        public string curso { get; set; }
        public double notaexamen { get; set; }
        public double notalaboratorio { get; set; }
        public double notaproyecto { get; set; }
        public double notaactitudinal { get; set; }
        public double promedio { get; set; }
        public string condicion { get; set; }

        public string color { get; set; }




    }
}