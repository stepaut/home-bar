using System.Collections.Generic;

namespace RecipeBook.Models;

public class Recipe
{
    public List<RecipeComponent> Components { get; } = new();
    public string Text { get; }
    public RecipeFamily Family { get; }
    public int Alco { get; }
}
