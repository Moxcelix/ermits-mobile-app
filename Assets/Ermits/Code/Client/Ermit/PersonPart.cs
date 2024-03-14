using UnityEngine;

[System.Serializable]
public class PersonPart
{
    [SerializeField] private string _name;
    [SerializeField] private MeshRenderer _meshRenderer;
    [SerializeField] private int _materialIndex;
    [SerializeField] private Color _defaultColor;

    public string Name => _name;

    public Color DefaultColor => _defaultColor;

    public void ChangeColor(Color color)
    {
        _meshRenderer.materials[_materialIndex].color = color;
    }
}