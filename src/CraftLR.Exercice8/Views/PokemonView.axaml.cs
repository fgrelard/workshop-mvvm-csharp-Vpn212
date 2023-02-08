using System;

using Avalonia.Controls;

using CraftLR.Exercice8.Services;
using CraftLR.Exercice8.ViewModels;

namespace CraftLR.Exercice8.Views;

public partial class PokemonView : Window
{
    public PokemonView()
    {
        InitializeComponent();
        DataContext = new PokemonViewModel(new PokemonService());
    }
}