using System;

namespace Prakticheski_izpit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eggs= int.Parse(Console.ReadLine());
            int green = 0;
            int orange = 0;
            int blue = 0;
            int red = 0;
            int max = 0;
            string colorMax = "";
            for (int i = 0; i < eggs; i++)
            {
                string color = Console.ReadLine();
                if (color=="green")
                {
                    green++;
                }
                else if (color=="blue")
                {
                    blue++;
                }
                else if (color == "red")
                {
                    red++;
                }
                else
                {
                    orange++;
                }
            }
            if (max<=red)
            {
                max = red;
                colorMax = "red";

            }
            if (red <= orange)
            {
                max= orange;
                colorMax = "orange";

            }
            if (blue >= orange)
            {
                max= blue;
                colorMax = "blue";

            }
            if (blue <= green)
            {
                max= green;
                colorMax = "green";
            }

            
            

            
            Console.WriteLine($"Red eggs: {red}");
            Console.WriteLine($"Orange eggs: {orange}");
            Console.WriteLine($"Blue eggs: {blue}");
            Console.WriteLine($"Green eggs: {green}");
            Console.WriteLine($"Max eggs: {max} -> {colorMax}");
        }
    }
}
