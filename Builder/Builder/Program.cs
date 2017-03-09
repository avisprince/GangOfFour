using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var mealBuilder = new MealBuilder();
            var vegMeal = mealBuilder.PrepareVeggieMeal();
            var beefMeal = mealBuilder.PrepareMeal();

            Console.WriteLine("Veggie Meal:");
            vegMeal.PrintItems();
            Console.WriteLine("Total Price = " + vegMeal.GetCost());

            Console.WriteLine("\n\n");
            
            Console.WriteLine("Beef Meal:");
            beefMeal.PrintItems();
            Console.WriteLine("Total Price = " + beefMeal.GetCost());
        }
    }
}
