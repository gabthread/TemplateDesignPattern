using System;

namespace TemplateDesignPatternDemo
{
    public class HeavyBreakfast : MakeBreakfastProcess
    {
        public override void CookIngredients()
        {
            Console.WriteLine("Cook HEAVY breakfast" + Environment.NewLine);

        }
    }
}
