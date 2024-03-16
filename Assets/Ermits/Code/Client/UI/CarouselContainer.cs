using UnityEngine;
using UnityEngine.UI;

public class CarouselContainer : MonoBehaviour
{
    [SerializeField] private Text _title;
    [SerializeField] private Button _nextButton;
    [SerializeField] private Button _prevButton;

    public void Initialize(string title,
        UnityEngine.Events.UnityAction nextEvent,
        UnityEngine.Events.UnityAction prevEvent)
    {
        _title.text = title;
        _nextButton.onClick.AddListener(nextEvent);
        _prevButton.onClick.AddListener(prevEvent);
    }
}
