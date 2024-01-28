using Classes.Recipes.Ingredients;
public class Recipe
{ 
    public List<Ingredient> RecipeIngredients { get; }
    public Recipe(List<Ingredient> allIngredients)
    {
        RecipeIngredients = allIngredients;
    }
    public override string ToString()
    {
        var recipeAsString = RecipeIngredients.Select(i => $"{i.Name}. {i.Instructions}");
        return string.Join("\n", recipeAsString);
    }
}

