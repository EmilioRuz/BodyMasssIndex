using System.ComponentModel;
using System.Windows.Input;
using BodyMasssIndex.GUI.Models;

namespace BodyMasssIndex.GUI.ViewModels
{
    public class MainViewModels: INotifyPropertyChanged
    {
        private string _nombre;
        //declaracion de la clase nombre
        public string Nombre
        {
            get => _nombre;
            set
            {
                if (_nombre != value)
                {
                    _nombre = value;
                    OnPropertyChanged(nameof(Nombre));
                }
            }
        }

        private double _peso;
        //declaracion de la clase peso

        public double Peso
        {
            get => _peso;
            set
            {
                if (_peso != value)
                {
                    _peso = value;
                    OnPropertyChanged(nameof(Peso));
                }
            }
        }

        private double _estatura;


        //declaracion de la clase Estatura

        public double Estatura
        {
            get => _estatura;
            set
            {
                if (_estatura != value)
                {
                    _estatura = value;
                    OnPropertyChanged(nameof(Estatura));
                }
            }
        }
        private double _indicedemasacorporal;
        
        public double Indicedemasacorporal
        {
            get => _indicedemasacorporal;
            set

            {
                if (value != _indicedemasacorporal)
                {
                    _indicedemasacorporal = value;
                    OnPropertyChanged(nameof(Indicedemasacorporal));
                }
            }
        }
        private string _situacionNutricional;
        //delcaracion de la situacion nutrimental
        public string SituacionNutricional
        {
            get => _situacionNutricional;
            set

            {
                if (value != _situacionNutricional)
                {
                    _situacionNutricional = value;
                    OnPropertyChanged(nameof(SituacionNutricional));
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public Persona Persona { get; set; }

        public ICommand CalcularImcCommand {  get; set; }
        public ICommand LimpiarCommand { get; set; }

        public MainViewModels()
        {
            Persona = null;
            CalcularImcCommand = new Command(CalcularImc);
            LimpiarCommand = new Command(Limpiar);
        }

        private void OnPropertyChanged(string propertyName)
           => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //se declara un nuevo tipo de persona con sus contenidos especificos
        private void CalcularImc()
        {
            Persona = new Persona(Nombre, Peso, Estatura);
            Indicedemasacorporal = CalculadoraImc.IndiceDeMasaCorporal
                (Persona.Peso, Persona.Estatura);
            SituacionNutricional = SituacionNutricionalComoTexto(Indicedemasacorporal);
        }
        //se delcara que limpiar hara que los datos queden en 0
        private void Limpiar()
        {
            Nombre = string.Empty;
            Peso = 0.0;
            Estatura = 0.0;
            Indicedemasacorporal = 0.0;
            SituacionNutricional = string.Empty;
        }
        
        private string SituacionNutricionalComoTexto(double imc)
        {
            CalculadoraImc.EstadoNutricional estadoNutricional =
            CalculadoraImc.SituacionNutricional(imc);

            //se declara cual sera el resultado en pantalla dependiendo de lo que salga

            switch (estadoNutricional)
            {
                case CalculadoraImc.EstadoNutricional.Pesobajo:
                    return "Peso bajo";
                case CalculadoraImc.EstadoNutricional.Pesonormal:
                    return "Peso normal";
                case CalculadoraImc.EstadoNutricional.Sobrepeso:
                    return "Sobrepeso";
                case CalculadoraImc.EstadoNutricional.Obesidad:
                    return "Obesidad";
                case CalculadoraImc.EstadoNutricional.ObesidadExtrema:
                    return "Obesidad extrema";
                default:
                    return string.Empty;
            }
        }


    }
  
}




