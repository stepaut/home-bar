using System;

namespace Bar.Models;

public class Ingredient : Thing
{
    public string Name { get; }
    public int Alco { get; }
    public bool IsExist { get; set; }

    public Guid Id { get; }

    internal Ingredient(string name, int alco, bool isExist, Guid id) : base(id)
    {
        Name = name;
        Alco = alco;
        IsExist = isExist;
    }
}
