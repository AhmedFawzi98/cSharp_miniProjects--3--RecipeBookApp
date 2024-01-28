using Classes.ProgramSettings;
using Classes.Recipes.Ingredients;
namespace Classes.App;

public interface IUserInteraction
    {
        void PrintExistingRecipes(List<Recipe> allRecipes);
        void ShowMsg(string msg);
        void PromptToCreateNewRecipe();
        List<Ingredient> ReadIngredientsFromUser();
        RepositoryFileFormat SelectFormat();
}
