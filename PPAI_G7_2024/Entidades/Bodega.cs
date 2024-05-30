using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_G7_2024.Entidades
{
    internal class Bodega
    {
        public string[] CoordenadasUbicacion { get; set; }
        public string Descripcion { get; set; }
        public string Historia { get; set; }
        public string Nombre { get; set; }
        public DateTime PeriodoActualizacion { get; set; }
        public List<Vino> Vinos { get; set; } = new List<Vino>();

        // Relación con RegionVitivinicola
        public RegionVitivinicola Region { get; set; }

        // Métodos
        public void ContarReseñas()
        {
            foreach (var vino in Vinos)
            {
                Console.WriteLine($"{vino.Nombre} tiene {vino.Reseñas.Count} reseñas.");
            }
        }

        public void MostrarTodosVinos()
        {
            foreach (var vino in Vinos)
            {
                Console.WriteLine(vino.Nombre);
            }
        }

        public string GetNombre() => Nombre;

        public RegionVitivinicola ObtenerRegionPais() => null; // ver como hacer

    }
}
