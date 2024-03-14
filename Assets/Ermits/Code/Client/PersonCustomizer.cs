using UnityEngine;

[System.Serializable]
public class PersonCustomizer
{
    [System.Serializable]
    private struct PartButton
    {
        public string name;
        public SceneButton sceneButton;
    }

    private CustomPerson _customPerson;
    private string _currentPartName;

    [SerializeField] private PartButton[] _buttons;

    public void Initialize()
    {
        foreach(var button in _buttons)
        {
            button.sceneButton.AddListener(() => SelectPart(button.name));
        }
    }

    public void SetPerson(CustomPerson person)
    {
        _customPerson = person;
    }

    public void SelectPart(string partName)
    {
        _currentPartName = partName;
    }

    public void ChangeColor(Color color)
    {
        _customPerson.SetColor(_currentPartName, color);
    }
}
