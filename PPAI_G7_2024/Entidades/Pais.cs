using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_G7_2024.Entidades
{
    internal class Pais
    {
        public string Nombre { get; set; }

        public string GetNombre() => Nombre;
        public void SetNombre(string nombre) => Nombre = nombre;
    }
}
