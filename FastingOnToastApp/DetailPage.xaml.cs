using ChaosOnToast.FastingOnToastApp.ViewModel;

namespace ChaosOnToast.FastingOnToastApp;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}