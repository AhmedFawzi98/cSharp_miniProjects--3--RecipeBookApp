using System.Threading.Tasks.Dataflow;

namespace Classes.Recipes.Ingredients;

public class AvailableIngredients
{
    public new Dictionary<int, Ingredient> AllIngredients { get; } = new Dictionary<int, Ingredient>
    {
        {1, new WheatFlour()},
        {2, new CoconutFlour()},
        {3, new Butter()},
        {4, new Chocolate()},
        {5, new Sugar()},
        {6, new Cinnamon()}
    };
    public override string ToString()
    {
        var AllIngredientsAsString = AllIngredients.Select(x => x.Value.ToString());
        return string.Join("\n", AllIngredientsAsString);
    }
}


