using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMasssIndex.Console.Models
{
    public class CalculadoraImc
    {
        public static double IndiceDeMasaCorporal(double peso, double estatura)
            => peso /Math.Pow(estatura, 2);


        public enum EstadoNutricional
        {
            Pesobajo,
            Pesonormal,
            Sobrepeso,
            Obesidad,
            ObesidadExtrema
        }

        public static EstadoNutricional SituacionNutricional(double imc)
        {
            if (imc < 18.5)
            {
                return EstadoNutricional.Pesobajo;
            }
            else if (imc < 25.0)
            {
                return EstadoNutricional.Pesonormal;
            }
            else if (imc < 30.0)
            {
                return EstadoNutricional.Sobrepeso;
            }
            else if (imc < 40.0)
            {
                return EstadoNutricional.Sobrepeso;
            }
            else
            {
                return EstadoNutricional.ObesidadExtrema;
            }
        }
    }
}
