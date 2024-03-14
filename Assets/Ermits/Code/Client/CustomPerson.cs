using Core.Customizer;
using UnityEngine;

public class CustomPerson : MonoBehaviour
{
    [System.Serializable]
    private class PersonPart
    {
        [SerializeField] private string _name;
        [SerializeField] private MeshRenderer _meshRenderer;
        [SerializeField] private int _materialIndex;
        [SerializeField] private UnityEngine.Color _defaultColor;

        public string Name => _name;
        public UnityEngine.Color DefaultColor => _defaultColor;

        public void ChangeColor(UnityEngine.Color color)
        {
            _meshRenderer.materials[_materialIndex].color = color;
        }
    }

    private Colorful _colorful;

    [SerializeField] private PersonPart[] _parts;

    private void Awake()
    {
        _colorful = new Colorful(_parts.Length);

        for (int i = 0; i < _parts.Length; i++)
        {
            _colorful.Coloreds[i] = new Colored(
                _parts[i].Name, ColorUnityToCostomizer(_parts[i].DefaultColor));
        }
    }

    private void Update()
    {
        for (int i = 0; i < _colorful.Coloreds.Length; i++)
        {
            var color = ColorCostomizerToUnity(_colorful.Coloreds[i].Color);

            _parts[i].ChangeColor(color);
        }
    }

    public void SetColors(Core.Customizer.Color[] colors)
    {
        for (int i = 0; i < colors.Length; i++)
        {
            var color = ColorCostomizerToUnity(colors[i]);

            _parts[i].ChangeColor(color);
        }
    }

    private UnityEngine.Color ColorCostomizerToUnity(Core.Customizer.Color color)
    {
        return new UnityEngine.Color(color.r, color.g, color.b);
    }
    private Core.Customizer.Color ColorUnityToCostomizer(UnityEngine.Color color)
    {
        return new Core.Customizer.Color() { r = color.r, g = color.g, b = color.b };
    }
}
