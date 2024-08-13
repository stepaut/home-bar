using System;
using System.Collections.Generic;
using System.Linq;

namespace Bar.Models;

public class Recipe : Thing
{
    public IReadOnlyCollection<RecipeComponent> Components => _components;
    private readonly HashSet<RecipeComponent> _components;

    public string Text { get; set; }
    public RecipeFamily Family { get; set; }
    public int Alco { get; set; }
    //TODO tags

    public Recipe(IEnumerable<RecipeComponent> components, string text, RecipeFamily family, int alco, Guid id) : base(id)
    {
        _components = components.ToHashSet();
        Text = text;
        Family = family;
        Alco = alco;
    }
}
