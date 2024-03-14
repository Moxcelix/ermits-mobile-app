using UnityEngine;

public class SceneButton : MonoBehaviour
{
    public delegate void ButtonClickedDelegate();
    public event ButtonClickedDelegate OnButtonClicked;

    private void OnMouseDown()
    {
        OnButtonClicked?.Invoke();
    }
}
