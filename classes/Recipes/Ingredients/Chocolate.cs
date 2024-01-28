namespace Classes.Recipes.Ingredients;

public class Chocolate : Ingredient
{
    public Chocolate(int iD = 4, string name = nameof(Chocolate)) : base(iD, name)
    {
    }
    public override string Instructions => $"Melt in water bath, Then {base.Instructions}";

}


