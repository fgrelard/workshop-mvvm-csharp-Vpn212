using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CraftLR.Exercice7;

public abstract class HelloButtonViewModelBase : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

public class HelloButtonViewModel : HelloButtonViewModelBase
{
    private string _buttonCaption;
    private int _numberOfClicks;
    public HelloButtonViewModel()
    {
        _buttonCaption = "Hello!";
        _numberOfClicks = 0;
    }

    public string ButtonCaption
    {
        get => _buttonCaption;
        set
        {
            if (_buttonCaption == value) return;
            _buttonCaption = value;
            OnPropertyChanged();
        }
    }

    public void CountClick()
    {
        _numberOfClicks++;
        ButtonCaption = $"{_numberOfClicks} Clicks";
    }
}