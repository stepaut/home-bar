using Bar.Database;
using Bar.Enums;
using RecipeBook.Models;

namespace Bar.Models;

public class Cocktail : IDbItem
{
    public Recipe Recipe { get; }
    public bool IsPossible { get; }
    public Rating Rating { get; }

    public string Id { get; }

    public void FromJson(string json)
    {
        throw new System.NotImplementedException();
    }

    public string ToJson()
    {
        throw new System.NotImplementedException();
    }
}
