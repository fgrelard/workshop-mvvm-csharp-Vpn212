using System;

using Avalonia.Controls;
using Avalonia.Interactivity;

namespace CraftLR.UI;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object sender, RoutedEventArgs eventData)
    {
        if (sender is Button button)
        {
            Console.Out.WriteLine($"Click on {button.Content}!");
        }
    }
}