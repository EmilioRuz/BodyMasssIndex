

namespace CalculadoraDeIndiceDeMasaCorporal.Models
{
    public class Persona
    {
        public string? Nombre { get; set; }
        public decimal Peso { get; set; }
        public decimal Estatura { get; set; }

        public Persona(string? nombre, decimal peso, decimal estatura)
        {
            Nombre = nombre;
            Peso = peso;
            Estatura = estatura;
        }
    }

}


