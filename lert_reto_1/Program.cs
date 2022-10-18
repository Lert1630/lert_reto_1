using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaVector2
{
    class PruebaVector2
    {
        private float[] notas;
        private float promedio;

        public void Cargar()
        {
            notas = new float[15];
            for (int f = 0; f < 15; f++)
            {
                Console.Write("Ingrese las notas de los alumnos:");
                string linea = Console.ReadLine();
                notas[f] = float.Parse(linea);
            }
        }
        public void NotasTotales()
        {
            float total = 0;
            for (int f = 0; f < 15; f++)
            {
                total = total + notas[f];
            }
            Console.WriteLine("Total de notas de los alumnos:" + total);
            Console.ReadKey();
        }

        public void CalcularPromedio()
        {
            float suma;
            suma = 0;
            for (int f = 0; f < 15; f++)
            {
                suma = suma + notas[f];
            }
            promedio = suma / 15;
            Console.WriteLine("Promedio de las notas de los alumnos :" + promedio);
        }

        public void MayoresMenores()
        {
            int may, men;
            may = 0;
            men = 0;
            for (int f = 0; f < 15; f++)
            {
                if (notas[f] > promedio)
                {
                    may++;
                }
                else
                {
                    if (notas[f] < promedio)
                    {
                        men++;
                    }
                }
            }
            Console.WriteLine("Cantidad de personas mayores al promedio:" + may);
            Console.WriteLine("Cantidad de personas menores al promedio:" + men);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            PruebaVector2 pv2 = new PruebaVector2();
            pv2.Cargar();
            pv2.CalcularPromedio();
            pv2.MayoresMenores();
            pv2.NotasTotales
                ();
        }
    }
}
