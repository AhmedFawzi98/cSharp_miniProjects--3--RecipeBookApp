using Classes.ProgramSettings;
using Classes.Recipes.Ingredients;
using Classes.App;
namespace Classes.UserInteraction;

    public class ConsoleUserInterAction : IUserInteraction
    {
        private readonly AvailableIngredients AllIngredients;
        private int AllIngredientsCount;

        public ConsoleUserInterAction(AvailableIngredients allIngredients)
        {
            AllIngredients = allIngredients;
            AllIngredientsCount = AllIngredients.AllIngredients.Count();
        }

        public void PrintExistingRecipes(List<Recipe> allRecipes)
        {
            int recipeNumber = 0;
            foreach (Recipe recipe in allRecipes)
            {
            Console.WriteLine($"-----------Recipe #{recipeNumber}------------");
            Console.WriteLine(recipe);
                recipeNumber++;
            }
        }
        public void PromptToCreateNewRecipe()
        {
        Console.WriteLine("\nCreate a new cookie recipe! Available ingredients are:");
        Console.WriteLine(AllIngredients); ;
        }

        public List<Ingredient> ReadIngredientsFromUser()
        {
            List<Ingredient> RecipeIngredients = new List<Ingredient>();
            bool isAdding = true;
            int id;
            while (isAdding)
            {
                Console.WriteLine("Add an ingredient by its ID or type anything else if finished.");

                isAdding = int.TryParse(Console.ReadLine(), out id);
                if (isAdding)
                {
                    if (id < 1 || id > AllIngredientsCount)
                        Console.WriteLine("invalid ingredient ID");
                    else
                    {
                        Console.WriteLine("Ingredient is added");
                        Ingredient ingredientToAdd = AllIngredients.AllIngredients[id];
                        RecipeIngredients.Add(ingredientToAdd);
                    }
                }
            }
            return RecipeIngredients;
        }

        public RepositoryFileFormat SelectFormat()
        {
            RepositoryFileFormat format;
            do
            {
                Console.WriteLine("choose file format to save recipes in:\n 1- txt\n 2- json");

            } while (!Enum.TryParse(Console.ReadLine(), true, out format));
            return format;

        }
         public void ShowMsg(string msg)
        {        
            Console.WriteLine(msg);
        }
    }