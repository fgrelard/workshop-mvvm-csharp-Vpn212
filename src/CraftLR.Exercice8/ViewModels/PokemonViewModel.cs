using System.Linq;
using System.Windows.Input;

using CraftLR.Exercice8.Models;
using CraftLR.Exercice8.Services;

using ReactiveUI;

namespace CraftLR.Exercice8.ViewModels;

public class PokemonViewModel : ReactiveObject
{
    private Pokemon _pokemon;

    public Pokemon Pokemon
    {
        get => _pokemon;
        set
        {
            this.RaiseAndSetIfChanged(ref _pokemon, value);
        }
    }

    public ICommand DisplayNextPokemonCommand { get; set; }
    public ICommand DisplayPreviousPokemonCommand { get; set; }

    public PokemonViewModel() : this(new PokemonService())
    {
    }

    public PokemonViewModel(PokemonService service)
    {
        var pokemons = service.GetItems().ToArray();
        int index = 0;
        Pokemon = pokemons.ElementAt(index);

        DisplayNextPokemonCommand = ReactiveCommand.Create(() =>
        {
            index = index + 1;

            if (index == pokemons.Length)
            {
                index = 0;
            }

            Pokemon = pokemons.ElementAt(index);
        });

        DisplayPreviousPokemonCommand = ReactiveCommand.Create(() =>
        {
            index = index - 1;

            if (index < 0)
            {
                index = pokemons.Length - 1;
            }

            Pokemon = pokemons.ElementAt(index);
        });
    }
}