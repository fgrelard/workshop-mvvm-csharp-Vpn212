using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

using CraftLR.Exercice8.Models;

using ReactiveUI;

namespace CraftLR.Exercice8.ViewModels;

public class PokemonViewModel : INotifyPropertyChanged
{
    private Pokemon _pokemon;
    public Pokemon Pokemon
    {
        get => _pokemon;
        set
        {
            _pokemon = value;
            OnPropertyChanged();
        }
    }

    public ICommand UpdateCommand { get; set; }

    public PokemonViewModel()
    {
        Pokemon = new Pokemon { Name = "Pikachu", Level = 5, Type = "Electric" };
        UpdateCommand = ReactiveCommand.Create(() =>
        {
            Pokemon.Name = "Charizard";
            Pokemon.Level = 50;
            Pokemon.Type = "Fire/Flying";
        });
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}