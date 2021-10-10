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
    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }
    private void FixedUpdate()
    {
        RB.MovePosition(RB.position + movement * speed * Time.fixedDeltaTime);
    }
}
