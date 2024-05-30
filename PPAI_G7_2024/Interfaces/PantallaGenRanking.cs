using PPAI_G7_2024.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_G7_2024.Interfaces
{
    public partial class PantallaGenRanking : Form
    {
        private Gestor.GestorGenRanking gestorRanking;
        List<string> TipoResenia = new List<string> { "De Sommelier", "De Enofilo" };
        List<string> formaDeVisualizacion = new List<string> { "Excel", "PDF", "Pantalla" };
        public PantallaGenRanking()
        {
            InitializeComponent();

            gestorRanking = new Gestor.GestorGenRanking(this);

            cmbReseña.DataSource = TipoResenia;
            cmbFormaDeVisualizacion.DataSource = formaDeVisualizacion;
            cmbReseña.Enabled = false;
            cmbFormaDeVisualizacion.Enabled = false;
            btnConfirmarGeneracion.Enabled = false;
        }
        public void OpcionRegistrarReservarDeRT()
        {
            habilitarVentana();
            gestorRanking.generarRankingVinos();
        }
        public void habilitarVentana()
        {
            this.Show();
        }
        private void validarFechas()
        {
            DateTime fechaDesde = dtpckFechaDesde.Value;
            DateTime fechaHasta = dtpckFechaHasta.Value;

            if (fechaDesde <= fechaHasta)
            {
                gestorRanking.tomarFechaDesdeHasta(fechaDesde, fechaHasta);
               
            }
            else
            {
                MessageBox.Show("El período no es válido. Asegúrese de que la fecha 'Hasta' sea mayor que la fecha 'Desde'.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void solicitarFechaDesdeHasta()
        {
            dtpckFechaDesde.Enabled = true;
            dtpckFechaHasta.Enabled = true;
        }

        
        private void tomarFechaDesde(object sender, EventArgs e)
        {
            dtpckFechaDesde.Enabled = false;
        }

        private void tomarFechaHasta(object sender, EventArgs e)
        {
            dtpckFechaHasta.Enabled = false;
            validarFechas();
        }

        public void solicitarTipoDeReseña()
        {
               cmbReseña.Enabled = true;
               
        }

        private void tomarTipoDeReseña(object sender, EventArgs e)
        {
            gestorRanking.tomarTipoReseña(cmbReseña.SelectedValue.ToString());


        }
        private void tomarFormaDeVisualizacion(object sender, EventArgs e)
        {
            gestorRanking.tomarFormaDeVisualizacion(cmbFormaDeVisualizacion.SelectedValue.ToString());
        }

        public void solicitarFormaDeVisualizacion()
        {
            cmbFormaDeVisualizacion.Enabled = true;
        }
        public void tomarConfirmGenReport()
        {
            btnConfirmarGeneracion.Enabled = true;
        }

        private void tomarConfirmarGenReport(object sender, EventArgs e)
        {
            List<Vino> vinos = new List<Vino>();
            gestorRanking.buscarVinosConReseñaEnPeriodo(vinos);
        }


    }
}
