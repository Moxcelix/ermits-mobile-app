using Core.Customizer;
using UnityEngine;

public class CustomPerson : MonoBehaviour
{
    private Colorful _colorful;

    [SerializeField] private PersonPart[] _parts;

    private void Awake()
    {
        _colorful = new Colorful(_parts.Length);

        for (int i = 0; i < _parts.Length; i++)
        {
            _colorful.Coloreds[i] = new Colored(
                _parts[i].Name, _parts[i].DefaultColor);
        }
    }

    private void Update()
    {
        for (int i = 0; i < _colorful.Coloreds.Length; i++)
        {
            _parts[i].ChangeColor(_colorful.Coloreds[i].Color);
        }
    }

    public void SetColors(Core.Customizer.Color[] colors)
    {
        for (int i = 0; i < colors.Length; i++)
        {
            _parts[i].ChangeColor(colors[i]);
        }
    }
}
