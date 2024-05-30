using PPAI_G7_2024.Entidades;
using PPAI_G7_2024.Gestor;
using PPAI_G7_2024.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_G7_2024
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PantallaPrincipal());

            // Crear 5 instancias de Vino con diferentes propiedades

            // Vino 1
            Vino vino1 = new Vino
            {
                Añada = "2018",
                ImagenEtiqueta = "imagen1.jpg",
                Nombre = "Vino Blanco Seco",
                NotaDeCataBodega = "Aromas a frutas cítricas y flores.",
                PrecioARS = 1200m,
                Varietales = new List<Varietal> { new Varietal("Chardonnay", 100) },
                Reseñas = new List<Reseña>
            {
                new Reseña
                {
                    Comentario = "Fresco y afrutado.",
                    EsPremium = true,
                    FechaReseña = new DateTime(2023, 1, 15),
                    Puntaje = 90
                }
            }
            };

            // Vino 2
            Vino vino2 = new Vino
            {
                Añada = "2019",
                ImagenEtiqueta = "imagen2.jpg",
                Nombre = "Vino Tinto Roble",
                NotaDeCataBodega = "Notas a frutos rojos y madera.",
                PrecioARS = 1800m,
                Varietales = new List<Varietal> { new Varietal("Malbec", 85), new Varietal("Cabernet Sauvignon", 15) },
                Reseñas = new List<Reseña>
            {
                new Reseña
                {
                    Comentario = "Complejo y bien equilibrado.",
                    EsPremium = true,
                    FechaReseña = new DateTime(2023, 2, 20),
                    Puntaje = 92
                }
            }
            };

            // Vino 3
            Vino vino3 = new Vino
            {
                Añada = "2020",
                ImagenEtiqueta = "imagen3.jpg",
                Nombre = "Vino Rosado",
                NotaDeCataBodega = "Fresco con notas a frutas del bosque.",
                PrecioARS = 1400m,
                Varietales = new List<Varietal> { new Varietal("Merlot", 100) },
                Reseñas = new List<Reseña>
            {
                new Reseña
                {
                    Comentario = "Refrescante y perfecto para el verano.",
                    EsPremium = false,
                    FechaReseña = new DateTime(2023, 3, 10),
                    Puntaje = 88
                }
            }
            };

            // Vino 4
            Vino vino4 = new Vino
            {
                Añada = "2021",
                ImagenEtiqueta = "imagen4.jpg",
                Nombre = "Vino Espumante Brut",
                NotaDeCataBodega = "Aromas a manzana verde y pan tostado.",
                PrecioARS = 2000m,
                Varietales = new List<Varietal> { new Varietal("Pinot Noir", 60), new Varietal("Chardonnay", 40) },
                Reseñas = new List<Reseña>
            {
                new Reseña
                {
                    Comentario = "Elegante y con buena acidez.",
                    EsPremium = true,
                    FechaReseña = new DateTime(2023, 4, 5),
                    Puntaje = 94
                }
            }
            };

            // Vino 5
            Vino vino5 = new Vino
            {
                Añada = "2017",
                ImagenEtiqueta = "imagen5.jpg",
                Nombre = "Vino Dulce Natural",
                NotaDeCataBodega = "Dulce con notas a miel y frutas tropicales.",
                PrecioARS = 1600m,
                Varietales = new List<Varietal> { new Varietal("Moscatel", 100) },
                Reseñas = new List<Reseña>
            {
                new Reseña
                {
                    Comentario = "Delicioso y perfecto como postre.",
                    EsPremium = false,
                    FechaReseña = new DateTime(2023, 5, 1),
                    Puntaje = 89
                }
            }
            };

            // Crear una lista de vinos y agregar las instancias creadas
            List<Vino> vinos = new List<Vino> { vino1, vino2, vino3, vino4, vino5 };
            GestorGenRanking gestor = new GestorGenRanking(vinos);
        }
    }
}
