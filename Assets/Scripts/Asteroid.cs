using UnityEngine;

public class Asteroid : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GetComponent<SpriteRenderer>().enabled = false; 
            Destroy(gameObject, 0.8f); // 
            collision.GetComponent<Nave>().gameOver();
        }
    }
}
