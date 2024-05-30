using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_G7_2024.Entidades
{
    internal class Provincia
    {
        public string Nombre { get; set; }
        public List<RegionVitivinicola> Regiones { get; set; } = new List<RegionVitivinicola>();

        // Relación con Pais
        public Pais Pais { get; set; }

        // Método para contar las regiones
        public int ContarRegiones() => Regiones.Count;

        // Método para mostrar las regiones
        public void MostrarRegiones()
        {
            foreach (var region in Regiones)
            {
                Console.WriteLine(region.Nombre);
            }
        }

        public Pais ObtenerPais() => null; // ver como hacer
    }
}
