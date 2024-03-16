using UnityEngine;

public class SceneButton : MonoBehaviour
{
    public delegate void ButtonClickedDelegate();
    private event ButtonClickedDelegate OnButtonClicked;

    public bool Enabled { get; set; } = true;

    private void OnMouseDown()
    {
        if (Enabled)
        {
            Invoke(nameof(Callback), 0.1f);
        }
    }

    private void Callback()
    {
        OnButtonClicked?.Invoke();
    }

    public void AddListener(ButtonClickedDelegate onButtonClicked)
    {
        OnButtonClicked += onButtonClicked;
    }
}
