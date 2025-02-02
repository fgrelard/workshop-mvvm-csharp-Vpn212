using System.Linq;
using System.Windows.Input;

using CraftLR.Exercice8.Models;
using CraftLR.Exercice8.Services;

using ReactiveUI;

namespace CraftLR.Exercice8.ViewModels;

public class PokemonViewModel : ReactiveObject
{
    private Pokemon _pokemon;

    public PokemonViewModel()
    {
        Pokemon[] pokemons = new[]
        {
            new Pokemon { Name = "Bulbizarre", Type = Type.Plante, Level = 5 },
            new Pokemon { Name = "Herbizarre", Type = Type.Plante, Level = 10 },
            new Pokemon { Name = "Florizarre", Type = Type.Plante, Level = 15 },
            new Pokemon { Name = "Salamèche", Type = Type.Feu, Level = 5 },
            new Pokemon { Name = "Reptincel", Type = Type.Feu, Level = 10 },
            new Pokemon { Name = "Dracaufeu", Type = Type.Feu, Level = 15 },
            new Pokemon { Name = "Carapuce", Type = Type.Eau, Level = 5 },
            new Pokemon { Name = "Carabaffe",Type = Type.Eau, Level = 10 },
            new Pokemon { Name = "Tortank", Type = Type.Eau, Level = 15 },
            new Pokemon { Name = "Chenipan", Type = Type.Insecte, Level = 5 },
            new Pokemon { Name = "Chrysacier",  Type = Type.Insecte, Level = 10 },
            new Pokemon { Name = "Papillon", Type = Type.Insecte, Level = 15 },
            new Pokemon { Name = "Aspicot",Type = Type.Insecte, Level = 5 },
            new Pokemon { Name = "Coconfort",  Type = Type.Insecte, Level = 10 },
            new Pokemon { Name = "Dardargnan", Type = Type.Insecte, Level = 15 },
            new Pokemon { Name = "Roucool", Type = Type.Normal, Level = 5 },
            new Pokemon { Name = "Roucoups",  Type = Type.Normal, Level = 10 },
            new Pokemon { Name = "Roucarnage", Type = Type.Normal, Level = 15 },
            new Pokemon { Name = "Rattata",  Type = Type.Normal, Level = 5 },
            new Pokemon { Name = "Rattatac",  Type = Type.Normal, Level = 10 },
            new Pokemon { Name = "Piafabec", Type = Type.Normal, Level = 5 },
            new Pokemon { Name = "Rapasdepic", Type = Type.Normal, Level = 10 },
        };

        int index = 0;
        Pokemon = pokemons.ElementAt(index);

        DisplayNextPokemonCommand = ReactiveCommand.Create(() =>
        {
            // A Completer
        });

        DisplayPreviousPokemonCommand = ReactiveCommand.Create(() =>
        {
            //A Completer
        });
    }

    public Pokemon Pokemon
    {
        get => _pokemon;
        set => this.RaiseAndSetIfChanged(ref _pokemon, value); // Si la valeur change, notification de la vue
    }

    public ICommand DisplayNextPokemonCommand { get; set; }
    public ICommand DisplayPreviousPokemonCommand { get; set; }
}