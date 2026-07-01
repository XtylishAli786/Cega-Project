using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject startPanel;
    public GameObject losePanel;
    public GameObject pausePanel;

    void Start()
    {
        Time.timeScale = 0f;
        startPanel.SetActive(true);
        losePanel.SetActive(false);
    }

    public void StartGame()
    {
        startPanel.SetActive(false);
        Time.timeScale = 1f;
        print("Game Started");
        pausePanel.SetActive(false);
    }

    public void GameOver()
    {
        losePanel.SetActive(true);
        Time.timeScale = 0f;
        print("Game Over");
    }


    public void PauseGame()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}