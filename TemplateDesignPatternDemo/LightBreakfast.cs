using System;

namespace TemplateDesignPatternDemo
{
    public class LightBreakfast : MakeBreakfastProcess
    {
        public override void CookIngredients()
        {
            Console.WriteLine("Cook LIGHT breakfast" + Environment.NewLine);
        }
    }
}
