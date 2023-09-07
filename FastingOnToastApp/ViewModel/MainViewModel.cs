using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaosOnToast.FastingOnToastApp.ViewModel;

public partial class MainViewModel : ObservableObject
{
    public MainViewModel()
    {
        Items = new ObservableCollection<string>()
        {"Autophagy", "Fat Burning", "Glycogen Burning", "Food Burning" };
    }

    [ObservableProperty]
    ObservableCollection<string> items;

    [ObservableProperty]
    string text;

    [RelayCommand]
    void Add()
    {
        if (string.IsNullOrWhiteSpace(Text))
            return;

        Items.Add(Text);
        Text = string.Empty;

    }


    [RelayCommand]
    void Delete(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
            return;

        if (Items.Contains(s))
            Items.Remove(s);

    }

    [RelayCommand]
    async Task Tap(string s)
    {
        await Shell.Current.GoToAsync($"{nameof(DetailPage)}?ID={s}");

    }
}
