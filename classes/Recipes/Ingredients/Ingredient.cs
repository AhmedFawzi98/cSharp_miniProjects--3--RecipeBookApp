namespace Classes.Recipes.Ingredients;
public abstract class Ingredient
{
    protected Ingredient(int iD, string name)
    {
        ID = iD;
        Name = name;
    }

    public int ID { get; }
    public string Name { get; }
    public virtual string Instructions => $"Add to other ingredients";
    public override string ToString()
    {
        return $"{ID}- {Name}";
    }
}


