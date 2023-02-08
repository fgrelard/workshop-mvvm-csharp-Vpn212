using System.Collections.Generic;

using CraftLR.Exercice8.Models;

namespace CraftLR.Exercice8.Services;

public class PokemonService
{
    public IEnumerable<Pokemon> GetItems() => new[]
    {
        new Pokemon { Name = "Bulbizarre", ID = 1, Type = Type.Plante, Level = 5 },
        new Pokemon { Name = "Herbizarre", ID = 2, Type = Type.Plante, Level = 10 },
        new Pokemon { Name = "Florizarre", ID = 3, Type = Type.Plante, Level = 15 },
        new Pokemon { Name = "Salamèche", ID = 4, Type = Type.Feu, Level = 5 },
        new Pokemon { Name = "Reptincel", ID = 5, Type = Type.Feu, Level = 10 },
        new Pokemon { Name = "Dracaufeu", ID = 6, Type = Type.Feu, Level = 15 },
        new Pokemon { Name = "Carapuce", ID = 7, Type = Type.Eau, Level = 5 },
        new Pokemon { Name = "Carabaffe", ID = 8, Type = Type.Eau, Level = 10 },
        new Pokemon { Name = "Tortank", ID = 9, Type = Type.Eau, Level = 15 },
        new Pokemon { Name = "Chenipan", ID = 10, Type = Type.Insecte, Level = 5 },
        new Pokemon { Name = "Chrysacier", ID = 11, Type = Type.Insecte, Level = 10 },
        new Pokemon { Name = "Papillon", ID = 12, Type = Type.Insecte, Level = 15 },
        new Pokemon { Name = "Aspicot", ID = 13, Type = Type.Insecte, Level = 5 },
        new Pokemon { Name = "Coconfort", ID = 14, Type = Type.Insecte, Level = 10 },
        new Pokemon { Name = "Dardargnan", ID = 15, Type = Type.Insecte, Level = 15 },
        new Pokemon { Name = "Roucool", ID = 16, Type = Type.Normal, Level = 5 },
        new Pokemon { Name = "Roucoups", ID = 17, Type = Type.Normal, Level = 10 },
        new Pokemon { Name = "Roucarnage", ID = 18, Type = Type.Normal, Level = 15 },
        new Pokemon { Name = "Rattata", ID = 19, Type = Type.Normal, Level = 5 },
        new Pokemon { Name = "Rattatac", ID = 20, Type = Type.Normal, Level = 10 },
        new Pokemon { Name = "Piafabec", ID = 21, Type = Type.Normal, Level = 5 },
        new Pokemon { Name = "Rapasdepic", ID = 22, Type = Type.Normal, Level = 10 },
    };
}