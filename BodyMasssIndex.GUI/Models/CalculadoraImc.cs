namespace BodyMasssIndex.GUI.Models
{
    //Creacion de la clase CalculadoraImc
    public class CalculadoraImc
    {
        public static double IndiceDeMasaCorporal(double peso, double estatura)
            => peso /Math.Pow(estatura, 2);

        //Se declaran los tipos de pesos
        public enum EstadoNutricional
        {
            Pesobajo,
            Pesonormal,
            Sobrepeso,
            Obesidad,
            ObesidadExtrema
        }
        //Dependiendo del resultado de la division entre el peso y la altura,se generara un tipo de respuesta
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
