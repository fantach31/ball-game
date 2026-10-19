using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class Pillarmanager : MonoBehaviour
{
    [SerializeField] public Colors pillarColor;
    private Renderer _renderer;
    void Start()
    {
        _renderer = GetComponent<Renderer>();

        switch (pillarColor)
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
