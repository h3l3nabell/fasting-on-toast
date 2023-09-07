using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaosOnToast.FastingOnToastApp.ViewModel;

[QueryProperty("Text", "ID")]
public partial class DetailViewModel : ObservableObject
{
    [ObservableProperty]
    string text;

    [RelayCommand]
    async Task GoBack(string s)
    {
        await Shell.Current.GoToAsync("..");

    }
}

