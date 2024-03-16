using System.Collections.Generic;
using UnityEngine;

namespace Core.Customizer
{
    [System.Serializable]
    public class MeshPart : IItem
    {
        [SerializeField] private Material[] _materials;
        [SerializeField] private Mesh _mesh;

        [SerializeField] private ColorCarousel[] _colorCarousels;
        [SerializeField] private TextureCarousel[] _textureCarousels;

        private readonly List<ICarousel> _carousels = new List<ICarousel>();

        public List<ICarousel> Carousels => _carousels;

        public Material[] Materials => _materials;

        public ColorCarousel[] ColorCarousels => _colorCarousels;

        public TextureCarousel[] TextureCarousels => _textureCarousels;

        public Mesh Mesh => _mesh;

        public void Initialize()
        {
            foreach(var carousel in _colorCarousels) 
            {
                carousel.Initialize();
            }

            foreach (var carousel in _textureCarousels)
            {
                carousel.Initialize();
            }

            AddIfNotEmpty(_colorCarousels);
            AddIfNotEmpty(_textureCarousels);
        }

        private void AddIfNotEmpty(ICarousel[] carousels)
        {
            foreach (var carousel in carousels)
            {
                if (carousel.Items.Count > 0)
                {
                    _carousels.Add(carousel);
                }
            }
            
        }
    }
}