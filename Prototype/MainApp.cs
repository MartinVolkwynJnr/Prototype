using System;

namespace Prototype
{
    class MainApp
    {
        static void Main(string[] args)
        {
            var colormanager = new ColorManager();

            // Initialize with standard colors
            colormanager[ColorType.Red] = new Color { Red = 255, Blue = 0, Green = 0 };
            colormanager[ColorType.Green] = new Color { Red = 0, Blue = 255, Green = 0 };
            colormanager[ColorType.Blue] = new Color { Red = 0, Blue = 0, Green = 255 };

            // User adds personalized colors
            colormanager[ColorType.Angry] = new Color { Red = 255, Blue = 54, Green = 0 };
            colormanager[ColorType.Peace] = new Color { Red = 128, Blue = 211, Green = 128 };
            colormanager[ColorType.Flame] = new Color { Red = 211, Blue = 34, Green = 20 };

            // User uses selected colors
            var color1 = colormanager[ColorType.Red].Clone() as Color;
            var color2 = colormanager[ColorType.Peace].Clone() as Color;

            // Creates a "deep copy"
            var color3 = colormanager[ColorType.Flame].Clone(false) as Color;

            // Wait for user
            Console.ReadKey();
        }
    }
}
