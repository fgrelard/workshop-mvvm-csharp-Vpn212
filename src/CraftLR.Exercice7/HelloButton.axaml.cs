using Avalonia.Controls;

namespace CraftLR.Exercice7;

public partial class HelloButton : Window
{
    public HelloButton()
    {
        InitializeComponent();
        DataContext = new HelloButtonViewModel();
    }
}