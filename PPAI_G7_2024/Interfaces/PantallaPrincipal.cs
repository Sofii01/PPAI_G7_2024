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
    public partial class PantallaPrincipal : Form
    {
        //private Gestor.GestorRegistrarReservaTurnoRT gestorTurnos;
        //private List<Tuple<DateTime, List<string[]>>> listaTurnosPorDia;

        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void opcGenerarRankingVinos(object sender, EventArgs e)
        {
            PantallaGenRanking pantallaGenRanking = new PantallaGenRanking();
            pantallaGenRanking.OpcionRegistrarReservarDeRT();
        }
    }
}
