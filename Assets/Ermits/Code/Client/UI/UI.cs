using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] private SceneButton[] _personPartButtons;
    [SerializeField] private GameObject _palette;

    public void Initialize()
    {
        _palette.SetActive(false);

        foreach (var button in _personPartButtons)
        {
            button.AddListener(OpenPallete);
        }
    }

    public void OpenPallete()
    {
        foreach (var button in _personPartButtons)
        {
            button.Enabled = false;
        }

        _palette.SetActive(true);
    }

    public void ClosePallete()
    {
        foreach (var button in _personPartButtons)
        {
            button.Enabled = true;
        }

        _palette.SetActive(false);
    }
}
