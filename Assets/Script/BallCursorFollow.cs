using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCursorFollow : MonoBehaviour
{
    // RigidBody Bola
    private Rigidbody2D RB;

    // Inisialisasi Kecepatan & posisi Mouse
    private Vector3 mousePos;
    public float speed;

    private void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        mousePos = Input.mousePosition; // get posisi cursor
        mousePos = Camera.main.ScreenToWorldPoint(mousePos); // get area screen 
        transform.position = Vector2.MoveTowards(transform.position, mousePos, speed * Time.deltaTime); // agar bergerak mengikuti mouse
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            Destroy(collision.gameObject);
        }
    }
}
