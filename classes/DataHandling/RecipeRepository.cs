using Classes.Recipes.Ingredients;
using System.Security.Cryptography.X509Certificates;

namespace Classes.RecipesRepository;

public class RecipeRepository : IRecipeRepository
{
    private readonly IStringTextRepository _stringRepository;
    private readonly AvailableIngredients _availableIngredients;

    public RecipeRepository(IStringTextRepository repository, AvailableIngredients availableIngredients )
    {
        _stringRepository = repository;
        _availableIngredients = availableIngredients;
    }

    public List<Recipe> Read(string filepath)
    {
        List<string> recipesAsStringList = _stringRepository.Read(filepath);
        List<Recipe> Recipes = new List<Recipe>();
        foreach (string recipeAsString in recipesAsStringList)
        {
            Recipe recipe = StringToRecipe(recipeAsString);
            Recipes.Add(recipe);
        }
        return Recipes;
    }
    private Recipe StringToRecipe(string recipeAsString)
    {
        List<Ingredient> RecipeIngredients = new List<Ingredient>();
        string[] recipeIngredientsIDs = recipeAsString.Split(',');
        foreach(string ingredientID in  recipeIngredientsIDs)
        {
            int IDAsInt = Convert.ToInt32(ingredientID);
            Ingredient oneIngredient = _availableIngredients.AllIngredients[IDAsInt];
            RecipeIngredients.Add(oneIngredient);
        }
        return new Recipe(RecipeIngredients);
    }

    public void Write(string filepath, List<Recipe> recipes)
    {
        List<string> recipesAsStrings = recipes.Select(rcp => string.Join(",", rcp.RecipeIngredients.Select(i => i.ID))).ToList();

        _stringRepository.Write(filepath, recipesAsStrings);
    }
}