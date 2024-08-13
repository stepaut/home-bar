using System.Collections.Generic;

namespace Bar.Models;

public class Bar
{
    public IReadOnlyCollection<Ingredient> Ingredients => _ingredients;
    private readonly HashSet<Ingredient> _ingredients = new();

    public IReadOnlyCollection<Cocktail> Cocktails => _cocktails;
    public readonly HashSet<Cocktail> _cocktails = new();
}
