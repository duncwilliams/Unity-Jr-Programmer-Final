using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainUIManager : MonoBehaviour
{
    private Button backToMenuButton;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CreateButtons();
    }

    private void CreateButtons()
    {
        // Initialize buttons
        backToMenuButton = GameObject.Find("Back To Menu Button").GetComponent<Button>();

        // Add listeners to buttons
        backToMenuButton.onClick.AddListener(BackToMenu);
    }

    private void BackToMenu()
    {
        SceneManager.LoadScene("Title");
    }
}
