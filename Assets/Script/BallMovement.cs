using UnityEngine;

public class BallMovement : MonoBehaviour
{
    // RigidBody Bola
    private Rigidbody2D RB;

    // Inisialisasi Kecepatan & Gerakan
    public float speed;
    private Vector2 movement;

    private void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // Move
        RB.MovePosition(RB.position + movement * speed * Time.fixedDeltaTime);
    }
}
