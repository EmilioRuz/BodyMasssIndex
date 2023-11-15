using BodyMasssIndex.Console.Models;

string? nombre;
double peso;
double estatura;
double imc;

Persona persona;


Console.WriteLine("Aplicacion que calcula el indice de masa corporal de una persona");

Console.Write("proporcione el nombre de la persona: ");
nombre  = Console.ReadLine();
peso = ReadDouble("proporcione los kilogramos de la persona:");
estatura = ReadDouble("proporcione la estatura de la persona:");

persona = new Persona(nombre, peso, estatura);

imc = CalculadoraImc.IndiceDeMasaCorporal(persona.Peso, persona.Estatura);

Console.WriteLine($"indice de masa corporal de {nombre}: {imc:F4}");

Console.WriteLine($"La situacion nutricional de {persona.Nombre} es {SituacionNutricionalComoTexto(imc)}");
double ReadDouble(string s)
{
    Console.Write(s);
    string? linea = Console.ReadLine();
    return Convert.ToDouble(linea);
}

string SituacionNutricionalComoTexto(double imc)
{
    CalculadoraImc.EstadoNutricional estadoNutrcional =
        CalculadoraImc.SituacionNutricional(imc);

    switch (estadoNutrcional)
    {
        case CalculadoraImc.EstadoNutricional.Pesobajo:
            return "Peso Bajo";
        case CalculadoraImc.EstadoNutricional.Pesonormal:
            return "Peso Normal";
        case CalculadoraImc.EstadoNutricional.Sobrepeso:
            return "Sobrepeso";
        case CalculadoraImc.EstadoNutricional.Obesidad:
            return "Obesidad";
        case CalculadoraImc.EstadoNutricional.ObesidadExtrema:
            return "Obesidad Extrema";
        default:
            return string.Empty;
    }
}