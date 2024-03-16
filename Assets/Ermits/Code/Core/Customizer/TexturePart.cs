using System.Collections.Generic;
using UnityEngine;

namespace Core.Customizer
{
    [System.Serializable]
    public class TexturePart : IItem
    {
        [SerializeField] private Texture _texture;
        [SerializeField] private int _materialIndex;

        public List<ICarousel> Carousels => null;

        public Texture Texture => _texture;

        public int MaterialIndex => _materialIndex;
    }
}