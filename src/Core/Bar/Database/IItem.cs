namespace Bar.Database;

internal interface IDbItem
{
    string Id { get; }

    string ToJson();
    void FromJson(string json);
}
