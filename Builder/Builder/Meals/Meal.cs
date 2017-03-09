using Builder.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Meals
{
    public class Meal
    {
        private List<IFoodItem> foodItems;

        public Meal()
        {
            this.foodItems = new List<IFoodItem>();
        }

        public void AddItem(IFoodItem item)
        {
            this.foodItems.Add(item);
        }

        public void RemoveItem(IFoodItem item)
        {
            this.foodItems.Remove(item);
        }

        public double GetCost()
        {
            return this.foodItems.Select(f => f.Price).Aggregate((nextItem, totalCost) => nextItem + totalCost);
        }

        public void PrintItems()
        {
            foreach (var item in this.foodItems)
            {
                Console.WriteLine("Item: " + item.Name);
                Console.WriteLine("Packing: " + item.Packing);
                Console.WriteLine("Price: " + item.Price);
                Console.WriteLine("");
            }
        }
    }
}
