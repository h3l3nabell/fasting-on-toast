using ChaosOnToast.FastingOnToastApp.ViewModel;

namespace ChaosOnToast.FastingOnToastApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}