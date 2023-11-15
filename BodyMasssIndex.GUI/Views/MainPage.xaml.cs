using BodyMasssIndex.GUI.ViewModels;

namespace BodyMasssIndex.GUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModels();

        }
    }

}
