using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_G7_2024.Entidades
{
    internal class RegionVitivinicola
    {
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public List<Bodega> Bodegas { get; set; } = new List<Bodega>();

        // Relación con Provincia
        public Provincia Provincia { get; set; }

        // Métodos
        public void ConocerBodegas()
        {
            foreach (var bodega in Bodegas)
            {
                Console.WriteLine(bodega.Nombre);
            }
        }

        public int ContarBodegas() => Bodegas.Count;

        public string GetNombre() => Nombre;

        public Pais ObtenerPais()
        {
            return Provincia.Pais; 
        }

    }
}
