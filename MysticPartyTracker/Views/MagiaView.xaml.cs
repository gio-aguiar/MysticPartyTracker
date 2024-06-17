namespace MysticPartyTracker.Views;
using MysticPartyTracker.ViewModels;
using System;

public partial class MagiaView : ContentPage
{

    private MagiaViewModel _magiaViewModel;
    public MagiaView()
    {
        InitializeComponent();
        _magiaViewModel = new MagiaViewModel();
        BindingContext = _magiaViewModel;
    }
}

