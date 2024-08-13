using System;

namespace Bar.Models;

public class RecipeFamily : Thing
{
    public string Name { get; }

    public RecipeFamily(string name, Guid id) : base(id)
    {
        Name = name;
    }
}
