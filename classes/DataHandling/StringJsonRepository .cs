using System.Text.Json;

namespace Classes.RecipesRepository;

public class StringJsonRepository : StringRepository
{
    protected override string StringtoText(List<string> recipes)
    {
        return JsonSerializer.Serialize(recipes);
    }

    protected override List<string> TextToStrings(string filepath)
    {
        return JsonSerializer.Deserialize<List<string>>(File.ReadAllText(filepath));
    }
}