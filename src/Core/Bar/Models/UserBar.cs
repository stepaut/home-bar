using Bar.Database;
using RecipeBook.Models;
using System.Collections.Generic;
using System.Linq;

namespace Bar.Models;

public class UserBar
{
    public IReadOnlyCollection<IngredientInBar> Ingredients => _ingredients;
    private readonly HashSet<IngredientInBar> _ingredients = new();

    public IReadOnlyCollection<Cocktail> Cocktails => _cocktails;
    public readonly HashSet<Cocktail> _cocktails = new();

    public Book Book { get; }

    private readonly string _path;

    private UserBar(IEnumerable<IngredientInBar> ingredients, IEnumerable<Cocktail> cocktails, Book book, string path)
    {
        foreach (var ingredient in ingredients)
        {
            _ingredients.Add(ingredient);
        }

        foreach (var cocktail in cocktails)
        {
            _cocktails.Add(cocktail);
        }

        Book = book;
        _path = path;
    }

    public static UserBar ReadFromDb(string path, Book book)
    {
        using var db = new BarContext(path);

        var ingridientThings = db.Ingredients.ToList();
        var cocktailThings = db.Cocktails.ToList();

        var ingrs = new List<IngredientInBar>();
        var cocktails = new List<Cocktail>();

        foreach (var thing in ingridientThings)
        {
            var ingr = IngredientInBar.FromJson(thing.JsonValue, book);
            if (ingr is null) continue; //TODO log
            ingrs.Add(ingr);
        }

        //TODO cocktails

        return new UserBar(ingrs, cocktails, book, path);
    }

    public void SaveInDb()
    {
        using var db = new BarContext(_path);


    }
}
