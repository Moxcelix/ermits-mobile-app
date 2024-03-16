using UnityEngine;

namespace Core.Customizer
{
    public class Colored
    {
        public string Name { get; }
        public Color Color { get; private set; }

        public Colored(string name, Color color)
        {
            Name = name;
            Color = color;
        }

        public void ChangeColor(Color color)
        {
            Color = color;
        }
    }
}