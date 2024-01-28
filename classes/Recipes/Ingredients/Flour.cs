namespace Classes.Recipes.Ingredients;

public abstract class Flour : Ingredient
{
    protected Flour(int iD, string name) : base(iD, name)
    {
    }

    public override string Instructions => $"Seive, Then {base.Instructions}";
}


