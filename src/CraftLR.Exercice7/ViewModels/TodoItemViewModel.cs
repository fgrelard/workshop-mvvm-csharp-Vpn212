using System.ComponentModel;

namespace CraftLR.Exercice7.ViewModels;

public class TodoItemViewModel : INotifyPropertyChanged
{
    private string _description;

    private bool _isChecked;

    public string Description
    {
        get => _description;
        set
        {
            if (_description == value) return;
            _description = value;
            OnPropertyChanged(nameof(Description)); // Raise the event for "Description"
        }
    }

    public bool IsChecked
    {
        get => _isChecked;
        set
        {
            if (_isChecked == value) return;
            _isChecked = value;
            OnPropertyChanged(nameof(IsChecked)); // Raise the event for "IsChecked"
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

#nullable enable

    protected virtual void OnPropertyChanged(string? propertyName)
    {
        var eventArgs = new PropertyChangedEventArgs(propertyName);
        PropertyChanged?.Invoke(this, eventArgs);
    }
}