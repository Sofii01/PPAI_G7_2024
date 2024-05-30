using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_G7_2024.Entidades
{
    internal class Vino
    {
        public string Añada { get; set; }
        public string ImagenEtiqueta { get; set; }
        public string Nombre { get; set; }
        public string NotaDeCataBodega { get; set; }
        public decimal PrecioARS { get; set; }
        public List<Varietal> Varietales { get; set; } = new List<Varietal>();
        public List<Reseña> Reseñas { get; set; } = new List<Reseña>();

        // Relación con Bodega
        public Bodega Bodega { get; set; }

        // Métodos
        public string GetNombre() => Nombre;

        public decimal GetPrecioARS() => PrecioARS;

        public void CalcularRanking()
        {
            // falta implementar
        }

        public void CompararEtiqueta()
        {
            // falta implementar
        }

        public void EsDeBodega(Bodega bodega)
        {
            // falta implementar
        }

        public void EsDeRegionVitivinicola()
        {
            // Implementación del método
        }

        public void tieneReseñasDeTipoEnPeriodo(string tipo, DateTime fechaDesde, DateTime fechaHasta)
        {
            List<Vino> vinosConReseñas = new List<Vino>();
            foreach (Reseña reseña in Reseñas)
            {
                if(tipo == "De Sommelier" && reseña.EsDeSommelier() && reseña.SosDePeriodo(fechaDesde, fechaHasta))
                {
                    String nombre = GetNombre();
                    decimal precio = GetPrecioARS();
                    String nombreBodega = BuscarInfoBodega();

                    //return list de vinos 
                }
               
            }
        }

        public String BuscarInfoBodega()
        {
            return Bodega.GetNombre();
        }
        public void BuscarVarietal()
        {
            // falta implementar
        }

        public void BuscarPuntajeDeSommelier()
        {
            // falta implementar
        }
        public void CalcularPuntajePromedio()
        {
            // falta implementar
        }
    }
}
