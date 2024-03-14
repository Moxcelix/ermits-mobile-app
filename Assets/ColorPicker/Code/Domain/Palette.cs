using System.Collections.Generic;

namespace Packages.ColorPicker
{
    public class Palette
    {
        private readonly List<PaletteColor> _colors = new List<PaletteColor>();

        private int _colorIndex = 0;

        public int SelectedColorIndex => _colorIndex;

        public void AddColor(PaletteColor color)
        {
            _colors.Add(color);
        }

        public void SelectColor(int index)
        {
            _colorIndex = index;
        }

        public PaletteColor GetColor(int index)
        {
            return _colors[index];
        }
    }
}