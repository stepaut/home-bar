using Bar.DTO;
using RecipeBook.Models;
using System.Text.Json;

namespace Bar.Models;

public class IngredientInBar
{
    public Ingredient Ingredient { get; }
    public bool IsExist { get; }

    private readonly string _id;


    public IngredientInBar(Ingredient ingredient, bool isExist, string id)
    {
        Ingredient = ingredient;
        IsExist = isExist;
        _id = id;
    }

    public static IngredientInBar? FromJson(string json, Book book)
    {
        var dto = JsonSerializer.Deserialize<IngredientInBarDTO>(json);

        if (dto?.Id is null) return null;
        if (dto?.IngredientName is null) return null;

        var ingredient = book.FindIngredientByName(dto.IngredientName);

        return new IngredientInBar(ingredient, dto.IsExist, dto.Id);
    }

    public string ToJson()
    {
        var dto = new IngredientInBarDTO()
        {
            IngredientName = Ingredient.Name,
            Id = _id,
            IsExist = IsExist,
        };

        return JsonSerializer.Serialize(dto);
    }
}
