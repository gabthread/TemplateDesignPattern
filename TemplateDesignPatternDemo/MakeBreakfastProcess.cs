using System;

namespace TemplateDesignPatternDemo
{
    public abstract class MakeBreakfastProcess
    {
        public void MakeBreakfast()
        {
            PrepareIngredients();
            CookIngredients();
            ServeFood();
        }

        private void PrepareIngredients()
        {
            Console.WriteLine("Prepare Ingredients.." + Environment.NewLine);
        }

        public abstract void CookIngredients();

        private void ServeFood()
        {
            Console.WriteLine("Serve Food.." + Environment.NewLine);
        }
    }
}
