using UnityEngine;

public class StartMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 0f; // Pause the game when the start menu is active
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        Time.timeScale = 1f; // Resume the game when the start button is pressed
        this.gameObject.SetActive(false); // Hide the start menu
    }

    public void QuitGame()
    {
        Application.Quit(); // Quit the application
    }
}
