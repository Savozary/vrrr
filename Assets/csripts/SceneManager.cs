using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public Button startButton;
    public Button exitButton;
    public Button infoButton;
    public Button backButton; //  нопка дл€ выхода в меню

    void Start()
    {
        startButton.onClick.AddListener(StartGame);
        exitButton.onClick.AddListener(ExitGame);
        infoButton.onClick.AddListener(OpenInfo);
        backButton.onClick.AddListener(BackToMenu);
    }

    void StartGame()
    {
        SceneManager.LoadScene("SampleScene"); // ”кажите им€ сцены вашей игры
    }

    void ExitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // ƒл€ остановки игры в редакторе
#endif
    }

    void OpenInfo()
    {
        SceneManager.LoadScene("info"); // ”кажите им€ сцены с информацией
    }

    void BackToMenu()
    {
        SceneManager.LoadScene("Menu"); // ”кажите им€ сцены меню
    }
}