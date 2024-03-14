using UnityEngine;

[System.Serializable]
public class PersonPart
{
    [SerializeField] private string _name;
    [SerializeField] private MeshRenderer _meshRenderer;
    [SerializeField] private int _materialIndex;
    [SerializeField] private Color _defaultColor;

    public string Name => _name;
    public Core.Customizer.Color DefaultColor => ColorUnityToCostomizer(_defaultColor);

    public void ChangeColor(Core.Customizer.Color color)
    {
        _meshRenderer.materials[_materialIndex].color = ColorCostomizerToUnity(color);
    }

    private Color ColorCostomizerToUnity(Core.Customizer.Color color)
    {
        return new Color(color.r, color.g, color.b);
    }
    private Core.Customizer.Color ColorUnityToCostomizer(Color color)
    {
        return new Core.Customizer.Color() { r = color.r, g = color.g, b = color.b };
    }
}