using PPAI_G7_2024.Interfaces;
using System;
using System.Collections.Generic;
using PPAI_G7_2024.Entidades;


namespace PPAI_G7_2024.Gestor
{
    class GestorGenRanking
    {
        private PantallaGenRanking pantallaRanking;
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private String tipoReseña;
        private String tipoVisualizacion;
        public List<Vino> vinos;
        public GestorGenRanking(PantallaGenRanking pantalla)
        {
            pantallaRanking = pantalla;

        }

        public GestorGenRanking(List<Vino> vinos)
        {
            this.vinos = vinos;
        }

        public void generarRankingVinos()
        {
            pantallaRanking.solicitarFechaDesdeHasta();

        }

        public void tomarFechaDesdeHasta(DateTime fD, DateTime fH)
        {
            fechaDesde = fD;
            fechaHasta = fH;
            pantallaRanking.solicitarTipoDeReseña();
        }

        public void tomarTipoReseña(String tR)
        {
            tipoReseña = tR;
            pantallaRanking.solicitarFormaDeVisualizacion();
        }
        public void tomarFormaDeVisualizacion(String tV)
        {
            tipoVisualizacion = tV;
            pantallaRanking.tomarConfirmGenReport();
        }

        public void buscarVinosConReseñaEnPeriodo(List<Vino> vinos)
        {
            var vinosFiltrados = vinos
                .Where(v => v.tieneReseñasDeTipoEnPeriodo(tipoReseña, fechaDesde, fechaHasta))
                .ToList();
            foreach (var vino in vinosFiltrados)
            {
             
                    string nombre = vino.GetNombre();
                    decimal precio = vino.GetPrecioARS();
                    string nombreBodega = vino.Bodega.GetNombre();
                    string region = vino.Bodega.Region.GetNombre();
                    string pais = vino.Bodega.Region.Provincia.Pais.GetNombre();
                    string varietal = vino.BuscarVarietal()



                Console.WriteLine($"Nombre: {nombre}, Precio: {precio}, Bodega: {nombreBodega}, Región: {region}, País: {pais}");
            }

        }
        public void buscarPuntajeDeSommelierEnPeriodo()
        {

            foreach(Vino vino in vinos)
            {

                double promedio = vino.BuscarPuntajeDeSommelier(fechaDesde, fechaHasta);
                Console.WriteLine($"Vino: {vino.GetNombre()}, Promedio de Sommelier: {promedio}");
            }
        }
        public double BuscarPuntajeGeneralEnPeriodo()
        {

            return vinos.BuscarPuntajeGeneral(fechaDesde, fechaHasta)
        }
        public List<Vino> ordenarVinos(List<Vino>)
        {
            //Ordena los vinos según la calificación de sommeliers de mayor a menor.
            return vinos.OrderByDescending(v => v.BuscarPuntajeDeSommelier(fechaDesde, fechaHasta)).ToList();
        }
    }
}
