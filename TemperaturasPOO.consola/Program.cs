using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturasPOO.consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[] temperaturas = new double[7];
            //List<double> temperaturas = new List<double>();
            List<>



            for (int i = 0; i < 7; i++)
            {
                var temperatura = ObtenerTemperatura(-10.0, 26.9);
                //temperaturas[i] = temperatura;
                temperaturas.Add(temperatura);
            }

            foreach (var temperatura in temperaturas)
            {
                Console.WriteLine(temperatura);
            }
            Console.WriteLine($"cantidad de temperaturas ingresadas: {temperaturas.Count}");
            Console.Read();
        }

        private static double ObtenerTemperatura(double LimiteInferior, double LimiteSuperior)
        {
            Random r = new Random(Guid.NewGuid().GetHashCode());
            var resultado = r.NextDouble() * (LimiteSuperior - LimiteInferior) + LimiteInferior;
            var parteDelNumero = resultado.ToString().Split(',');
            var parteEntera = parteDelNumero[0];
            var parteDecimal = parteDelNumero[1];
            return Convert.ToDouble($"{parteEntera},{parteDecimal[0]}");

        }
    }
}
