using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector2 direction;
    [SerializeField] private Rigidbody2D playerRigidbody2D;
    Keyboard keyboard;

    void Awake()
    {
        keyboard = Keyboard.current;
        playerRigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        DetectDirection();
        Move();
    }

    private void DetectDirection()
    {
        direction = Vector2.zero;
        if (keyboard.wKey.isPressed) direction += Vector2.up;
        if (keyboard.sKey.isPressed) direction += Vector2.down;
        if (keyboard.aKey.isPressed) direction += Vector2.left;
        if (keyboard.dKey.isPressed) direction += Vector2.right;
        direction.Normalize();
    }

    private void Move()
    {
        transform.position += (Vector3)direction * speed * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Carrot"))
        {
            Debug.Log("Player collided with Carrot");
            Destroy(other.gameObject);
        }
    }
}
