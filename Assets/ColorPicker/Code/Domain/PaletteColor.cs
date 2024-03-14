using UnityEngine;

namespace Packages.ColorPicker
{
    public class PaletteColor
    {
        private readonly Color _color;

        public Color Color => _color;

        public PaletteColor(Color color)
        {
            _color = color;
        }
    }
}