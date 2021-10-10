using UnityEngine;

public class BoxPoint : MonoBehaviour
{
    public int BoxPointValue = 10;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            ScoreManager.instance.UpdateScore(BoxPointValue);
        }
    }
}
