using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndiceDeMasaCorporal.Models
{
    public class CalculadoraImc
    {
       
        public enum EstadoNutricional
        {
            Pesobajo,
            Pesonormal,
            Sobrepeso,
            Obesidad,
            ObesidadExtrema
        }

        public static decimal IndiceDeMasaCorporal(decimal peso, decimal estatura) 
            => peso / (estatura * estatura);

        public static EstadoNutricional SituacionNutricional(decimal imc)
        {
            if (imc < 18.5M)
            {
                return EstadoNutricional.Pesobajo;
            }
            else if (imc < 25.0M)
            {
                return EstadoNutricional.Pesonormal;
            }
            else if (imc < 30.0M)
            {
                return EstadoNutricional.Sobrepeso;
            }
            else if (imc < 40.0M)
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
