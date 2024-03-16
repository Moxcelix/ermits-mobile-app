using System.Collections.Generic;
using UnityEngine;

namespace Core.Customizer
{
    [System.Serializable]
    public class ColorCarousel : ICarousel
    {
        [SerializeField] private List<ColorPart> _colorParts;

        private int _currentItemIndex = 0;

        public List<IItem> Items { get; private set; }

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