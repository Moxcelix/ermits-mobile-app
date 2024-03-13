using Core.Customizer;
using UnityEngine;

public class CustomPerson : MonoBehaviour
{
    private Colorful _colorful;

    [SerializeField] private MeshRenderer[] _parts;

    public void Initialize(Colorful colorful)
    {
        _colorful = colorful;
    }

    private void Update()
    {
        for(int i = 0; i <_colorful.Coloreds.Length; i++)
        {
            var color = GetColor(_colorful.Coloreds[i].Color);

            _parts[i].material.color = color;
        }
    }

    private UnityEngine.Color GetColor(Core.Customizer.Color color)
    {
        return new UnityEngine.Color(color.r, color.g, color.b);
    }
}
