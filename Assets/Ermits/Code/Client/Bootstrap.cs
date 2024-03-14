using Packages.ColorPicker;
using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private CustomPerson _customPerson;
    [SerializeField] private UI _ui;
    [SerializeField] private PaletteUI _pallete;

    [SerializeField] private PersonCustomizer _personCustomizer;

    private void Awake()
    {
        _ui.Initialize();
        _personCustomizer.Initialize();

        _personCustomizer.SetPerson(_customPerson);
        _pallete.AddColorSelectListener(_personCustomizer.ChangeColor);
    }
}
