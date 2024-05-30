using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_G7_2024.Entidades
{
    internal class Reseña
    {
        public string Comentario { get; set; }
        public bool EsPremium { get; set; }
        public DateTime FechaReseña { get; set; }
        public int Puntaje { get; set; }

        // Relación con Vino
        public Vino Vino { get; set; }

        // Métodos
        public bool GetEsPremium() => EsPremium;

        public int GetPuntaje() => Puntaje;

        public void SosDeEnofilo()
        {
            // falta implementar
        }

        public bool SosDeSommelier()
        {
            if (EsPremium)
            {
                return true;
            }
            else { return false; }
        }
        public bool SosDePeriodo(DateTime fD, DateTime fH)
        {
            if (FechaReseña>= fD && FechaReseña>= fH)
            {
                return true;
            }
            else { return false; }
        }
    }
}
