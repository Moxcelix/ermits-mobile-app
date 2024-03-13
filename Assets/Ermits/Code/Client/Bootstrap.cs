using Core.Customizer;
using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private CustomPerson _customPerson;

    private Colorful _personColorful;

    private void Awake()
    {
        int coloredPartsCount = 6;
        string[] names = new string[] 
        {
            "Head",
            "Body",
            "Rihgt arm",
            "Left arm",
            "Right leg",
            "Left leg"
        };

        _personColorful = new Colorful(coloredPartsCount);

        for(int i = 0; i < coloredPartsCount; i++)
        {
            _personColorful.Coloreds[i] = new Colored(names[i], new Core.Customizer.Color());
        }

        _customPerson.Initialize(_personColorful);
    }
}
