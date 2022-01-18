// See https://aka.ms/new-console-template for more information
var color = "";
var food = "";

FavoriteColor(ref color);
FavoriteFood(food);
PrintColor(color);
PrintFood(food);


static void FavoriteColor(ref string color)
{
    Console.WriteLine("Please enter your favorite color.");

    color = Console.ReadLine();
}

static void PrintColor(string color)
{
    Console.WriteLine($"Your favorite color is {color}.");
}

static void FavoriteFood(string food)
{
    Console.WriteLine("Please enter your favorite food.");

    food = Console.ReadLine();
}

static void PrintFood(string food)
{
    Console.WriteLine($"Your favorite food is {food}.");
}