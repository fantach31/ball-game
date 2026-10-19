using UnityEngine;

public class ColorGate : MonoBehaviour
{
    [SerializeField] private Colors gateColor;
    private Renderer _renderer;
    void Start()
    {
        _renderer = GetComponent<Renderer>();

        switch (gateColor)
        {
            case Colors.red:
                _renderer.material.color = Color.red;
                break;
            case Colors.yellow:
                _renderer.material.color = Color.yellow;
                break;
            case Colors.green:
                _renderer.material.color = Color.green;
                break;
            case Colors.blue:
                _renderer.material.color = Color.blue;
                break;
            default:
                break;


        }
    }

    // Update is called once per frame
    void Update()
    {

    }

}
