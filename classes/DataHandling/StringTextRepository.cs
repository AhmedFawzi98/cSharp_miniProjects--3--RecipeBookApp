namespace Classes.RecipesRepository;

public class StringTextRepository : StringRepository
{

    protected override string StringtoText(List<string> recipes)
    {
        return string.Join("\n", recipes);
    }

    protected override List<string> TextToStrings(string filepath)
    {
        return File.ReadAllText(filepath).Split("\n").ToList();
    }
}