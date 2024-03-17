using Core.Customizer;
using UnityEngine;

public class CustomSaver : MonoBehaviour
{
    private readonly string _saveToken = "custom";

    [SerializeField] private MeshCarousel[] _carousels;

    private void Start()
    {
        for (int i = 0; i < _carousels.Length; i++)
        {
            if(!PlayerPrefs.HasKey(_saveToken + i.ToString()))
            {
                continue;
            }

            var save = PlayerPrefs.GetString(_saveToken + i.ToString());

            ChoiseSaver.Load(_carousels[i], save);
        }
    }

    private void Update()
    {
        for(int i = 0; i < _carousels.Length; i++)
        {
            PlayerPrefs.SetString(_saveToken + i.ToString(), ChoiseSaver.Save(_carousels[i]));
        }
    }
}
