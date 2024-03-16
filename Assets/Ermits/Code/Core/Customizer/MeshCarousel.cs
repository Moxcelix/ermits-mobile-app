using System.Collections.Generic;
using UnityEngine;

namespace Core.Customizer
{
    public class MeshCarousel : MonoBehaviour, ICarousel
    {
        [SerializeField] private string _name;
        [SerializeField] private List<MeshPart> _meshParts;

        private int _currentItemIndex = 0;

        public List<IItem> Items { get; private set; }

        public MeshPart CurrentMeshPart => _meshParts[_currentItemIndex];

        public string Title => _name;

        private void Awake()
        {
            Items = new List<IItem>();

            foreach (var part in _meshParts)
            {
                part.Initialize();

                Items.Add(part);
            }
        }

        public void Next()
        {
            _currentItemIndex++;

            if(_currentItemIndex >= Items.Count)
            {
                _currentItemIndex = 0;
            }
        }

        public void Prev()
        {
            _currentItemIndex--;

            if(_currentItemIndex < 0)
            {
                _currentItemIndex = Items.Count - 1;
            }
        }
    }
}