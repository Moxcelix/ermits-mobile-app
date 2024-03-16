using System.Collections.Generic;
using UnityEngine;

namespace Core.Customizer
{
    [System.Serializable]
    public class ColorCarousel : ICarousel
    {
        [SerializeField] private string _name;
        [SerializeField] private List<ColorPart> _colorParts;

        private int _currentItemIndex = 0;

        public List<IItem> Items { get; private set; }

        public ColorPart CurrentColorPart => _colorParts[_currentItemIndex];

        public string Title => _name;

        public void Initialize()
        {
            Items = new List<IItem>();

            foreach (var part in _colorParts)
            {
                Items.Add(part);
            }
        }

        public void Next()
        {
            _currentItemIndex++;

            if (_currentItemIndex >= Items.Count)
            {
                _currentItemIndex = 0;
            }
        }

        public void Prev()
        {
            _currentItemIndex--;

            if (_currentItemIndex < 0)
            {
                _currentItemIndex = Items.Count - 1;
            }
        }
    }
}