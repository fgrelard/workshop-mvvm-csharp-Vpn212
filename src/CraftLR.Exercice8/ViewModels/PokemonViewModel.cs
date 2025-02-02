using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

using Avalonia.Media.Imaging;
using Avalonia.Platform;
using Avalonia.Rendering.Composition;

using CraftLR.Exercice8.Models;
using CraftLR.Exercice8.Services;

using DynamicData;

using ReactiveUI;

namespace CraftLR.Exercice8.ViewModels;

public class PokemonViewModel : ReactiveObject
{
    private Pokemon _pokemon;
    private Bitmap _imageToView;
    private List<Pokemon> _pokemons;
    private int _index;

    public PokemonViewModel() : this(new PokemonService())
    {
    }

    public PokemonViewModel(PokemonService service)
    {
        _pokemons = service.GetItems().ToList();
        _index = 0;
        Pokemon = _pokemons.ElementAt(_index);

        DisplayNextPokemonCommand = ReactiveCommand.Create((Action)(() =>
        {
            _index = _index + 1;

            if (_index == _pokemons.Count)
            {
                _index = 0;
            }

            Pokemon = _pokemons.ElementAt(_index);
        }));

        DisplayPreviousPokemonCommand = ReactiveCommand.Create((Action)(() =>
        {
            _index = _index - 1;

            if (_index < 0)
            {
                _index = _pokemons.Count - 1;
            }

            Pokemon = _pokemons.ElementAt(_index);
        }));
    }

    public Pokemon Pokemon
    {
        get => _pokemon;
        set
        {
            this.RaiseAndSetIfChanged(ref _pokemon, value);
            string UriString = $"avares://CraftLR.Exercice8/Assets/{Pokemon.Name.ToLower(System.Globalization.CultureInfo.CurrentCulture)}.png";
            ImageToView = new Bitmap(AssetLoader.Open(new Uri(UriString)));
        }
    }

    public Bitmap ImageToView
    {
        get => _imageToView;
        set
        {
            this.RaiseAndSetIfChanged(ref _imageToView, value);
        }
    }

    public List<Pokemon> Pokemons
    {
        get => _pokemons;
        set
        {
            this.RaiseAndSetIfChanged(ref _pokemons, value);
        }
    }

    public ICommand DisplayNextPokemonCommand { get; set; }
    public ICommand DisplayPreviousPokemonCommand { get; set; }

    public ICommand SelectionPokemon { get; set; }
}