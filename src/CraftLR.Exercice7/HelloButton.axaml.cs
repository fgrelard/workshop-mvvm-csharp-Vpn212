using System;

using Avalonia.Controls;
using Avalonia.Interactivity;

namespace CraftLR.Exercice7;

public partial class HelloButton : Window
{
    public HelloButton()
    {
        InitializeComponent();
        DataContext = new HelloButtonViewModel();
    }
}