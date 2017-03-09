using Builder.Items;
using Builder.Items.Drinks;
using Builder.Meals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class MealBuilder
    {
        public Meal PrepareVeggieMeal()
        {
            var meal = new Meal();
            meal.AddItem(new VeggieBurger());
            meal.AddItem(new DietCoke());

            return meal;
        }

        public Meal PrepareMeal()
        {
            var meal = new Meal();
            meal.AddItem(new BeefBurger());
            meal.AddItem(new Coke());

            return meal;
        }
    }
}
