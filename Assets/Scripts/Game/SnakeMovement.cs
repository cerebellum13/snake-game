using UnityEngine;

public class SnakeMovement : MonoBehaviour
{
    public float Speed = 15;

    private Rigidbody2D componentRigidbody;
    public static SnakeTail componentSnakeTail;

    private void Start()
    {
        componentRigidbody = GetComponent<Rigidbody2D>();
        componentSnakeTail = GetComponent<SnakeTail>();
        componentRigidbody.velocity = Vector2.left * Speed;
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            componentRigidbody.velocity = Vector2.up * Speed;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            componentRigidbody.velocity = Vector2.down * Speed;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            componentRigidbody.velocity = Vector2.left * Speed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            componentRigidbody.velocity = Vector2.right * Speed;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            componentSnakeTail.AddCircle();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            componentSnakeTail.RemoveCircle();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision!");
        if (collision.gameObject.name.Contains("SnakePart"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        }
    }
}