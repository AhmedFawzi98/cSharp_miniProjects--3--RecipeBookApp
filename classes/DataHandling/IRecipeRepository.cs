namespace Classes.RecipesRepository;

public interface IRecipeRepository
{
    List<Recipe> Read(string filepath);
    void Write(string filepath, List<Recipe> recipes);
}
