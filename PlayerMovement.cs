using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal"); // Detecta A/D o Flechas Izq/Der
        float moveY = Input.GetAxis("Vertical");   // Detecta W/S o Flechas Arr/Abajo

        rb.linearVelocity = new Vector2(moveX * speed, moveY * speed);
    }
}
