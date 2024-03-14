using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

namespace Packages.ColorPicker
{
    public class PaletteUI : MonoBehaviour
    {
        public delegate void OnColorSelectDelegate(Color color);
        private event OnColorSelectDelegate onColorSelectEvent;

        private readonly List<ColorVariantUI> _colorVariants = new List<ColorVariantUI>();

        private Palette _pallete;

        [SerializeField] private Transform _variantsOrigin;
        [SerializeField] private Button _confirmButton;

        public Palette Palette => _pallete;

        private void Awake()
        {
            _pallete = new Palette();

            _confirmButton.onClick.AddListener(() => onColorSelectEvent?.Invoke(
                    _pallete.GetColor(_pallete.SelectedColorIndex).Color));

            foreach (Transform child in _variantsOrigin)
            {
                if (child.TryGetComponent<ColorVariantUI>(out var colorVariant))
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

        public void AddColorSelectListener(OnColorSelectDelegate call)
        {
            onColorSelectEvent += call;
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