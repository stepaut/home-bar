namespace Bar.Database;

internal class Thing
{
    public string Id { get; set; }
    public string JsonValue { get; set; }


    public Thing(string id, string jsonValue)
    {
        Id = id;
        JsonValue = jsonValue;
    }

    public Thing()
    {
        Id = "error";
        JsonValue = "error";
    }
}
