using System;


namespace MyExtensions
{
    public static class StringExtension
    {
        public static bool ValidColor(this String str)
        {
            Console.ResetColor();
            switch (str.ToLower())
            {
                case "red": return true;
                case "blue": return false;
                case "green": return true;
                default: return false;
            }
        }
    }
}

namespace MainStuff
{
    using MyExtensions;
    public abstract class Reset
    {
        public abstract void ColorReset();
    } 
    interface IBaseColors
    {
        void Red();
        void Blue();
    }

    interface ISecondaryColors : IBaseColors
    {
        void Green();
    }

    

    public class Color : ISecondaryColors
    {
        

        public void Red()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Color changed to red");
        }
        public void Blue()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Color changed to blue");
        }
        public void Green()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Color changed to green");
        }
        
    }

    class MainClass : Reset
    {
        public override void ColorReset()
        {
            Console.ResetColor();
            Console.WriteLine("Color reset");
        }
        static void Main()
        {
            Console.WriteLine("Only red and green colors are allowed");
            Console.WriteLine("Here's the start");
            string colorChoice = "white";
            Color color = new Color();
            Console.WriteLine("1. white");

            colorChoice = "red";
            if (colorChoice.ValidColor())
            {
                color.Red();
            }
            Console.WriteLine("2. red");

            colorChoice = "blue";
            if (colorChoice.ValidColor())
            {
                color.Blue();
            }
            Console.WriteLine("3. blue");

            colorChoice = "green";
            if (colorChoice.ValidColor())
            {
                color.Green();
            }
            Console.WriteLine("4. green");
            Console.WriteLine(colorChoice.ValidColor());
            Console.WriteLine("Here's the end");

        }
    }
}