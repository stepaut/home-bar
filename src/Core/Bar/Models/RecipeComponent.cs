using System;

namespace Bar.Models;

public class RecipeComponent : Thing
{
    public Ingredient Ingredient { get; }
    public int Volume { get; set; }
    public bool IsRequired { get; set; }

    public RecipeComponent(Ingredient ingredient, int volume, bool isRequired, Guid id) : base(id)
    {
        Ingredient = ingredient;
        Volume = volume;
        IsRequired = isRequired;
    }
}
