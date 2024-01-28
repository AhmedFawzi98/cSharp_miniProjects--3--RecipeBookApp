namespace Classes.RecipesRepository
{
    public interface IStringTextRepository
    {
        List<string> Read(string filepath);
        void Write(string filepath, List<string> recipes);
    }
}
