using Bar.Enums;
using System;

namespace Bar.Models;

public class Cocktail : Thing
{
    public Recipe Recipe { get; }
    public bool IsPossible { get; set; }
    public Rating Rating { get; set; }


    public Cocktail(Recipe recipe, bool isPossible, Rating rating, Guid id) : base(id)
    {
        Recipe = recipe;
        IsPossible = isPossible;
        Rating = rating;
    }
}
