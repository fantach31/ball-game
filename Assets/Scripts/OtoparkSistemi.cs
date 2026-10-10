using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] int stayTime = 0;
    void Start()
    {
        timeCheck();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void timeCheck()
    {
        Debug.Log($"Otoparkta kalýnan süre: {stayTime} saat"); // Bütün caselere ayrý ayrý yazmaktansa burda her ihtimali halletmek istedim.
        switch (stayTime)
        {
            case 0:
                Debug.Log("Ödenecek Ücret: 0 TL");
                break;
            case 1:
                Debug.Log("Ödenecek Ücret: 120 TL");
                break;
            case 2:
                Debug.Log("Ödenecek Ücret: 200 TL");
                break;
            case 3:
                Debug.Log("Ödenecek Ücret: 300 TL");
                break;
            case 4:
                Debug.Log("Ödenecek Ücret: 400 TL");
                break;
            case 5:
                Debug.Log("Ödenecek Ücret: 550 TL");
                break;
            default:
                Debug.Log("Ödenecek Ücret: 550 TL");
                break;

        }
    }
    

}
