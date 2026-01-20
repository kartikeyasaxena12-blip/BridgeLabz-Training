using System;

// Interface
interface IMealPlan
{
    void ShowMeal();
}

// Vegetarian meal
class VegetarianMeal : IMealPlan
{
    public void ShowMeal()
    {
        Console.WriteLine("Vegetarian Meal: Rice, Dal, Vegetables");
    }
}

// Vegan meal
class VeganMeal : IMealPlan
{
    public void ShowMeal()
    {
        Console.WriteLine("Vegan Meal: Quinoa, Beans, Salad");
    }
}

// Generic class
class Meal<T> where T : IMealPlan, new()
{
    public void GenerateMeal()
    {
        T meal = new T(); 
        meal.ShowMeal();
    }
}

// Main class
class Program
{
    static void Main()
    {
        Meal<VegetarianMeal> vegMeal = new Meal<VegetarianMeal>();
        vegMeal.GenerateMeal();

        Meal<VeganMeal> veganMeal = new Meal<VeganMeal>();
        veganMeal.GenerateMeal();

        Console.ReadLine();
    }
}
