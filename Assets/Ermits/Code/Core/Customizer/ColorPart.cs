using System.Collections.Generic;
using UnityEngine;

namespace Core.Customizer
{
    [System.Serializable]
    public class ColorPart : IItem
    {
        [SerializeField] private Color _color;
        [SerializeField] private int _materialIndex;
        
        public List<ICarousel> Carousels => null;

        public Color Color => _color;

        public int MaterialIndex => _materialIndex;
    }
}