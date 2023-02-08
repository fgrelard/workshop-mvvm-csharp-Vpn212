namespace CraftLR.Exercice7;

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