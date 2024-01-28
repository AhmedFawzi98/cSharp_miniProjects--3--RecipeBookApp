using System.Text.Json;

namespace Classes.RecipesRepository
{
    public abstract class StringRepository : IStringTextRepository
    {

        public List<string> Read(string filepath)
        {
            if (File.Exists(filepath))
                return TextToStrings(filepath);
            return new List<string>();
        }

        protected abstract List<string> TextToStrings(string filepath);

        public void Write(string filepath, List<string> recipes)
        {
            File.WriteAllText(filepath, StringtoText(recipes));
        }

        protected abstract string StringtoText(List<string> recipes);
    }
}

