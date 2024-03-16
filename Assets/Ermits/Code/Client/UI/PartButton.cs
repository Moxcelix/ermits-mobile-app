using UnityEngine;
using Core.Customizer;

[RequireComponent(typeof(SceneButton))]
public class PartButton : MonoBehaviour
{
    [SerializeField] private MeshCarousel _meshCarousel;

    private SceneButton _sceneButton;

    public SceneButton SceneButton => _sceneButton;

    public MeshCarousel MeshCarousel => _meshCarousel;

    private void Awake()
    {
        _sceneButton = GetComponent<SceneButton>();
    }
}
