using Classes.RecipesRepository;

namespace Classes.App;

public class RecipeBook
{
    private readonly IRecipeRepository _recipeRepository;
    private readonly IUserInteraction _userInteraction;
    public RecipeBook(IUserInteraction userInteraction, IRecipeRepository recipeRepository)
    {
        _recipeRepository = recipeRepository;
        _userInteraction = userInteraction;
    }
    public void Run(string filepath)
    {
        List<Recipe> AllExistingRecipes = _recipeRepository.Read(filepath);
        _userInteraction.PrintExistingRecipes(AllExistingRecipes);

        _userInteraction.PromptToCreateNewRecipe();
        var recipeIngredients = _userInteraction.ReadIngredientsFromUser();
        if (recipeIngredients.Count == 0)
            _userInteraction.ShowMsg("No ingredients have been selected.Recipe will not be saved.");
        else
        {
            _userInteraction.ShowMsg("Recipe is added.");

            Recipe recipe = new Recipe(recipeIngredients);
            _userInteraction.ShowMsg(recipe.ToString());

            AllExistingRecipes.Add(recipe);

            _recipeRepository.Write(filepath, AllExistingRecipes);
        }
    }


}
