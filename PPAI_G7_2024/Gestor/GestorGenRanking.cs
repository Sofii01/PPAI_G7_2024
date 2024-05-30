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
            foreach (Vino vino in vinos)
            {
              vino.tieneReseñasDeTipoEnPeriodo(tipoReseña, fechaDesde, fechaHasta);
            }
        }
        public void buscarPuntajeDeSommelierEnPeriodo()
        {
            // pendiente
        }
        public List<Vino> ordenarVinos(List<Vino>)
        {
            //ordenar vinos por...
            return;
        }
    }
}
