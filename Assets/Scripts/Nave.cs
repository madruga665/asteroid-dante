using UnityEngine.UI;
using UnityEngine;

public class Nave : MonoBehaviour
{
    public float speed;
    public int stars;
    public Text scoreText;
    public Text scoreNumber;
    public Text highScore;
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

        if (stars > 10)
        {
            Time.timeScale = 1.1f;
        }
        if (stars > 20)
        {
            Time.timeScale = 1.2f;
        }
        if (stars > 30)
        {
            Time.timeScale = 1.3f;
        }
        if (stars > 40)
        {
            Time.timeScale = 1.4f;
        }
        if (stars > 50)
        {
            Time.timeScale = 1.5f;
        }
        if (stars > 60)
        {
            Time.timeScale = 1.6f;
        }
        if (stars > 100)
        {
            Time.timeScale = 2f;
        }

    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        gameOverScreen.SetActive(true);
        scoreNumber.text = stars.ToString();
        FindAnyObjectByType<Sounds>().PlayGameOverSound();

        if (stars > PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", stars);
        }

        highScore.text = PlayerPrefs.GetInt("highScore").ToString();

        Debug.Log("Game Over! A nave colidiu com o asteroide!");
    }
}
