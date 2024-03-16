using Core.Customizer;
using UnityEngine;
using UnityEngine.UI;

public class CustomizerUI : MonoBehaviour
{
    [SerializeField] private PartButton[] _partButtons;

    [SerializeField] private CarouselContainer _containerPrefab;

    [SerializeField] private Transform _containerOrigin;

    [SerializeField] private Text _title;

    [SerializeField] private GameObject _menu;

    private MeshCarousel _currentCarousel = null;

    private void Start()
    {
        foreach (var partButton in _partButtons)
        {
            partButton.SceneButton.AddListener(() => OpenPart(partButton.MeshCarousel));
        }

        CloseMenu();
    }

    public void CloseMenu()
    {
        _currentCarousel = null;
        _title.text = string.Empty;
        _menu.SetActive(false);
    }

    private void OpenPart(MeshCarousel part)
    {
        _menu.SetActive(true);

        _currentCarousel = part;

        _title.text = _currentCarousel.Title;

        foreach (Transform item in _containerOrigin)
        {
            Destroy(item.gameObject);
        }

        if (_currentCarousel.Items.Count > 1)
        {
            AddCarouselSwitcher(_currentCarousel);
        }

        foreach (var item in _currentCarousel.CurrentMeshPart.Carousels)
        {
            AddCarouselSwitcher(item);
        }
    }

    private void AddCarouselSwitcher(ICarousel carousel)
    {
        if (carousel == null)
        {
            return;
        }

        var container = Instantiate(_containerPrefab, _containerOrigin.transform);
        container.transform.localScale = Vector3.one;
        container.Initialize(carousel.Title,
            () =>
            {
                carousel.Next();
                OpenPart(_currentCarousel);
            },
            () =>
            {
                carousel.Prev();
                OpenPart(_currentCarousel);
            });
    }
}
