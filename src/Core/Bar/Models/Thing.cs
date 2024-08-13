using System;

namespace Bar.Models;

public class Thing
{
    public Guid Id { get; }

    public Thing(Guid id)
    {
        Id = id;
    }
}
