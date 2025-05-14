using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    private Button backToMenuButton;
    private Button restartButton;
    private int points;
    
    public TextMeshProUGUI scoreCounterText;
    public GameObject gameOverText;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CreateButtons();

        points = 0;
    }

    private void CreateButtons()
    {
        // Initialize buttons
        backToMenuButton = GameObject.Find("Back To Menu Button").GetComponent<Button>();
        restartButton = GameObject.Find("Restart Button").GetComponent<Button>();

        // Add listeners to buttons
        backToMenuButton.onClick.AddListener(BackToMenu);
        restartButton.onClick.AddListener(Restart);

        // Hide Restart Button
        restartButton.gameObject.SetActive(false);
    }

    private void BackToMenu()
    {
        SceneManager.LoadScene("Title");
    }

    private void Restart()
    {
        SceneManager.LoadScene("Main");
    }

    public void AddPoints(int pointsToAdd)
    {
        points += pointsToAdd;

        if (points == 1)
        {
            scoreCounterText.text = points + " Point";  
        }
        else
        {
            scoreCounterText.text = points + " Points";
        }
    }

    public void GameOver()
    {
        gameOverText.SetActive(true);
        restartButton.gameObject.SetActive(true);
    }
}
