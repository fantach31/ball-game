using UnityEngine;

public class Ballmanager : MonoBehaviour
{
    private Colors gate2Color;
    [SerializeField] public Colors ballColor;
    [SerializeField] private float moveSpeed = 3.5f;
    private Renderer _renderer;
    [SerializeField] Transform startPos;
    private Transform _transform;
    private bool hasColor = false;
    void Start()
    {
        _renderer = GetComponent<Renderer>();
        _transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    private void Movement()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, vertical);

        transform.Translate(direction * (moveSpeed * Time.deltaTime), Space.World);


    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit something.");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Gate Red") && !other.CompareTag("Gate Yellow") && !other.CompareTag("Finish Area"))
        {
            Debug.Log($"You are {other.tag} now");
        }

        if (other.CompareTag("Red"))
        {
            _renderer.material.color = Color.red;
            ballColor = Colors.red;
            hasColor = true;
        }
        else if (other.CompareTag("Yellow"))
        {
            _renderer.material.color = Color.yellow;
            ballColor = Colors.yellow;
            hasColor = true;
        }
        else if (other.CompareTag("Green"))
        {
            _renderer.material.color = Color.green;
            ballColor = Colors.green;
            hasColor = true;
        }
        else if (other.CompareTag("Blue"))
        {
            _renderer.material.color = Color.blue;
            ballColor = Colors.blue;
            hasColor = true;
        }
        else if (other.CompareTag("Gate Red"))
        {
            if (ballColor == Colors.red && hasColor)
            {
                Debug.Log("Same color red");
            }
            else
            {
                Debug.Log("Baþa dön");
                _transform.position = startPos.position;
            }


        }
        else if (other.CompareTag("Gate Yellow"))
        {
            if (ballColor == Colors.yellow && hasColor)
            {
                Debug.Log("Same color yellow");
            }
            else
            {
                Debug.Log("Baþa dön");
                _transform.position = startPos.position;
            }
        }
        else if (other.CompareTag("Finish Area"))
        {
        
            Debug.Log("Oyun Bitti!");
           
        }

    }

}
