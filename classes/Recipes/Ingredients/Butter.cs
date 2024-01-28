namespace Classes.Recipes.Ingredients;

public class Butter : Ingredient
{
    public Butter(int iD = 3, string name = nameof(Butter)) : base(iD, name)
    {
    }
    public override string Instructions => $"Melt in low heat, Then {base.Instructions}";

}


