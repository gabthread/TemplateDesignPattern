using System;

namespace TemplateDesignPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            MakeBreakfastProcess makeLightBreakfast = new LightBreakfast();
            Console.WriteLine("*********** Making Light Breakfast ******** " + Environment.NewLine);
            makeLightBreakfast.MakeBreakfast();


            MakeBreakfastProcess makeHeavyBreakfast = new HeavyBreakfast();
            Console.WriteLine("*********** Making Heavy Breakfast ******** " + Environment.NewLine);
            makeHeavyBreakfast.MakeBreakfast();

            Console.ReadKey();

        }
    }
}
