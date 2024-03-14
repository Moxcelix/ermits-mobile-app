using UnityEngine;
using UnityEngine.UI;

namespace Packages.ColorPicker
{
    public class ColorVariantUI : MonoBehaviour
    {
        [SerializeField] private Image _colorSample;
        [SerializeField] private Button _selectButton;
        [SerializeField] private GameObject _selectContainer;

        public bool IsSelected { get; set; } = false;

        public Color Color => _colorSample.color;

        private void Update()
        {
            _selectContainer.SetActive(IsSelected);
        }

        public void AddClickListener(UnityEngine.Events.UnityAction call) 
        {
            _selectButton.onClick.RemoveAllListeners();
            _selectButton.onClick.AddListener(call);
        }
    }
}