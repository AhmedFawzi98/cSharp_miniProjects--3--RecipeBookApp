using Classes.App;
using Classes.ProgramSettings;
using Classes.Recipes.Ingredients;
using Classes.RecipesRepository;
using Classes.UserInteraction;

ConsoleUserInterAction consoleUserInteraction = new ConsoleUserInterAction(new AvailableIngredients());

RepositoryFileFormat format = consoleUserInteraction.SelectFormat();
string fileName = "recipes";

AppMetaData appMetaData = new AppMetaData(fileName, format);

RecipeRepository recipeRepository = (format == RepositoryFileFormat.json) ?
    new RecipeRepository(new StringTextRepository(), new AvailableIngredients()) :
    new RecipeRepository(new StringJsonRepository(), new AvailableIngredients());


RecipeBook RecipeBookApp = new RecipeBook(consoleUserInteraction, recipeRepository);

RecipeBookApp.Run(appMetaData.FilePath);