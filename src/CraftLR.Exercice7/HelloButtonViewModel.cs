namespace CraftLR.Exercice7;

using System;
using System.Net.NetworkInformation;
using System.Reactive;

using ReactiveUI;

public class HelloButtonViewModel : HelloButtonViewModelBase
{
    private string _buttonCaption = "Hello!";
    private int _numberOfClicks;
    private bool _enable = true;
    private const int MAXNUMBERCLICKS = 5;

    public bool Enable
    {
        get => _enable;
        set
        {
            _enable = value;
            Console.WriteLine(_enable);
            OnPropertyChanged();
        }
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
        Enable = _numberOfClicks < MAXNUMBERCLICKS;
    }
}