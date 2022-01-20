using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;

namespace WpfAppSnakeGame
{
    public class SnakePart
    {
        public UIElement UiElement { get; set; }

        public Point Position { get; set; }

        public bool IsHead { get; set; }
    }
}
