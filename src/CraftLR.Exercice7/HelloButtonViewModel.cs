namespace CraftLR.Exercice7;

public class HelloButtonViewModel : HelloButtonViewModelBase
{
    private string _buttonCaption = "Hello!";
    private int _numberOfClicks;

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