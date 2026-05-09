using UnityEngine.UI;
using UnityEngine;

public class Nave : MonoBehaviour
{
    public float speed;
    public int stars;
    public Text scoreText;
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        float horizontalInput = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float verticalInput = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        rb.linearVelocity = new Vector2(horizontalInput, verticalInput);
    }

    public void countStars()
    {
        stars += 1;
        scoreText.text = stars.ToString();
        Debug.Log("Pontuação: " + stars);
    }

    public void gameOver()
    {
        Debug.Log("Game Over! A nave colidiu com o asteroide!");
    }
}
