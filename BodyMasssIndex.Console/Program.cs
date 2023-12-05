using CalculadoraDeIndiceDeMasaCorporal.Models;


    string? nombre;
decimal peso;
decimal estatura;
decimal imc;
Persona persona;
string estadoNutricional;


Console.WriteLine("Aplicacion que calcula el indice de masa corporal de una persona");

try
{
    // Entrada de datos
    Console.Write("Proporcione el nombre de la persona: ");
    nombre = Console.ReadLine();
    
    peso = ReadDecimal("Peso de la persona en kilogramos: ");
    estatura = ReadDecimal("Estatura de la persona en metros: ");
    
    // Procesamiento
    persona = new Persona(nombre, peso, estatura);
    imc = CalculadoraImc
        .IndiceDeMasaCorporal(persona.Peso, persona.Estatura);
    estadoNutricional = SituacionNutricionalComoTexto(imc);
    // Salida de datos
    Console.WriteLine();
    
    Console.WriteLine($"{persona.Nombre} pesa {persona.Peso} kilogramos y mide " +
        $"{persona.Estatura} metros.\n");
    
    Console.WriteLine($"{persona.Nombre} tiene un índice de masa corporal de {imc} kg/m2.");
    
    Console.WriteLine($"La situación nutricional de {persona.Nombre} es {estadoNutricional}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
    decimal ReadDecimal(string s) 
{ 
    decimal numero; 
    Console.Write(s); 
    string? entrada = Console.ReadLine(); 
    if (!decimal.TryParse(entrada, out numero)) 
    { 
        throw new FormatException("El valor proporcionado no es un número."); 
    }
    return numero; 
}
    string SituacionNutricionalComoTexto(decimal imc)
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