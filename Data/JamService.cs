namespace BlazorApp.Data;

class JamService
{
    private readonly List<Variety> _varieties = new()
    {
        new(){ Name = "Гала", JamMultiplier = 0.7m },
        new(){ Name = "Голден", JamMultiplier = 0.5m }
    };

    public Variety GetByName(string varietyName)
    {
        if (string.IsNullOrWhiteSpace(varietyName))
            throw new Exception("Не задан сорт яблок");

        var result = _varieties.FirstOrDefault(v => v.Name.Equals(varietyName));

        return result ?? throw new Exception($"Не найден сорт яблок: {varietyName}");
    }
}
