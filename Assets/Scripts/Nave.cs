using UnityEngine.UI;
using UnityEngine;

public class Nave : MonoBehaviour
{
    public float speed;
    public int stars;
    public Text scoreText;
    public Text scoreNumber;
    private Rigidbody2D rb;
    public GameObject gameOverScreen;
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

    public void CountStars()
    {
        stars += 1;
        scoreText.text = stars.ToString();
        Debug.Log("Pontuação: " + stars);
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        gameOverScreen.SetActive(true);
        scoreNumber.text = stars.ToString();
        FindAnyObjectByType<Sounds>().PlayGameOverSound();
        Debug.Log("Game Over! A nave colidiu com o asteroide!");
    }
}
