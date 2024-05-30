using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_G7_2024.Entidades
{
    internal class Varietal
    {
       
        public Varietal(string Descripcion, double PorcentajeComposicion)
        {
            this.Descripcion = Descripcion;
            this.PorcentajeComposicion = PorcentajeComposicion;
        }

        public string Descripcion { get; set; }
        public double PorcentajeComposicion { get; set; }

        // Métodos
        public double MostrarPorcentaje() => PorcentajeComposicion;

        public string GetDescripcion() => Descripcion;
    }
}
