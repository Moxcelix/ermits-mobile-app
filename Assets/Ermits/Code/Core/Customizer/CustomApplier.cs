using UnityEngine;

namespace Core.Customizer
{
    [RequireComponent(typeof(SkinnedMeshRenderer))]
    public class CustomApplier : MonoBehaviour
    {
        [SerializeField] private MeshCarousel _meshCarousel;

        private SkinnedMeshRenderer _meshRenderer;

        private void Awake()
        {
            _meshRenderer = GetComponent<SkinnedMeshRenderer>();
        }

        private void Update()
        {
            _meshRenderer.materials = _meshCarousel.CurrentMeshPart.Materials;
            _meshRenderer.sharedMesh = _meshCarousel.CurrentMeshPart.Mesh;

            foreach (var carousel in _meshCarousel.CurrentMeshPart.ColorCarousels)
            {
                if (carousel == null || carousel.Items.Count == 0)
                {
                    continue;
                }

                _meshRenderer.materials
                    [carousel.CurrentColorPart.MaterialIndex].color =
                    carousel.CurrentColorPart.Color;
            }
        }
    }
}