using UnityEngine;
using System.Collections.Generic;

namespace Packages.ColorPicker
{
    public class PaletteUI : MonoBehaviour
    {
        private readonly List<ColorVariantUI> _colorVariants = new List<ColorVariantUI>();

        private Palette _pallete;

        [SerializeField] private Transform _variantsOrigin;

        public Palette Palette => _pallete;

        private void Awake()
        {
            _pallete = new Palette();

            foreach (Transform child in _variantsOrigin)
            {
                if(child.TryGetComponent<ColorVariantUI>(out var colorVariant))
                {
                    _colorVariants.Add(colorVariant);
                }
            }

            for (int i = 0; i < _colorVariants.Count; i++)
            {
                var paletteColor = new PaletteColor(_colorVariants[i].Color);
                var index = i;

                _pallete.AddColor(paletteColor);

                _colorVariants[i].AddClickListener(() => OnColorVariantClick(index));
            }
        }

        private void OnColorVariantClick(int index)
        {
            _pallete.SelectColor(index);

            for (int i = 0; i < _colorVariants.Count; i++)
            {
                _colorVariants[i].IsSelected = i == _pallete.SelectedColorIndex;
            }
        }
    }
}