using System.Collections.Generic;

namespace Prototype
{
    //CLIENT
    class ColorManager
    {
        Dictionary<ColorType, Color> colors = new Dictionary<ColorType, Color>();

        // Gets or sets color
        public Color this[ColorType type]
        {
            get { return colors[type]; }
            set { colors.Add(type, value); }
        }
    }
}