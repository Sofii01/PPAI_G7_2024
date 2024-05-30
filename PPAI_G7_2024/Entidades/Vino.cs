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

        public List<Vino> ObtenerVinos()
        {
            List<Vino> vinos = new List<Vino>();
            return vinos;
        }

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

        public Boolean tieneReseñasDeTipoEnPeriodo(string tipo, DateTime fechaDesde, DateTime fechaHasta)
        {
            
            foreach (Reseña reseña in Reseñas)
            {
                if(tipo == "De Sommelier" && reseña.EsDeSommelier() && reseña.SosDePeriodo(fechaDesde, fechaHasta))
                {
                    return true;
                }
               
            }
            return false;
        }

        public String BuscarInfoBodega()
        {
            return Bodega.GetNombre();
        }
        public String BuscarVarietal()
        { //busco en la lista varietales de esta clase y traigo la descripcion de cada varietal
            foreach (Varietal varietal in Varietales)
            {
                return varietal.GetDescripcion()
            }
        }

        public double BuscarPuntajeDeSommelier(DateTime fechaDesde, DateTime fechaHasta)
        {
            var reseñasSommelier = Reseñas.Where(r => r.EsDeSommelier() && r.SosDePeriodo(fechaDesde, fechaHasta)).ToList();
            int suma = reseñasSommelier.Sum(r => r.GetPuntaje());
            int cantidad = reseñasSommelier.Count;

            return CalcularPuntajePromedio(suma, cantidad);
        }
        public double BuscarPuntajeGeneral(DateTime fechaDesde, DateTime fechaHasta)
        {
            var reseñasGeneral = Reseñas.Where(r => r.SosDeEnofilo && r.SosDePeriodo(fechaDesde, fechaHasta)).toList();
            int suma = reseñasGeneral.Sum(r => r.GetPuntaje());
            int cantidad = reseñasGeneral.Count;
            return CalcularPuntajePromedio(suma, cantidad);
        }
        public double CalcularPuntajePromedio(int suma, int cantidad)
        {
            return cantidad > 0 ? Math.Round((double)suma / cantidad, 2) : 0;
        }

    }
}
