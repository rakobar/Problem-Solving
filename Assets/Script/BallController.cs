using UnityEngine;

public class BallController : MonoBehaviour
{
    // RigidBody Bola
    private Rigidbody2D RB;

    // Besaran gaya awal yang di berikan untuk mendorong bola
    public float xInitForce;
    public float yInitForce;

    void ResetBall()
    {
        // Reset posisi dan kecepatan ke kordinat awal (0,0)
        transform.position = Vector2.zero;
        RB.velocity = Vector2.zero;
    }
    void PushBall() {
        // Menentukan nilai acak
        float randomDirection = Random.Range(0, 2);
        if (randomDirection < 1.0f)
        {
            RB.AddForce(new Vector2(-xInitForce,-yInitForce));
        }
        else
        {
            RB.AddForce(new Vector2(xInitForce, yInitForce));
        }
    }
    void Restart()
    {
        ResetBall();
        Invoke("PushBall", 2);
    }

    private void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        Restart();
    }
}
