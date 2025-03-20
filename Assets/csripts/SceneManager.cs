using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public Button startButton;
    public Button exitButton;
    public Button infoButton;
    public Button backButton; // ������ ��� ������ � ����

    void Start()
    {
        startButton.onClick.AddListener(StartGame);
        exitButton.onClick.AddListener(ExitGame);
        infoButton.onClick.AddListener(OpenInfo);
        backButton.onClick.AddListener(BackToMenu);
    }

    void StartGame()
    {
        SceneManager.LoadScene("SampleScene"); // ������� ��� ����� ����� ����
    }

    void ExitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // ��� ��������� ���� � ���������
#endif
    }

    void OpenInfo()
    {
        SceneManager.LoadScene("info"); // ������� ��� ����� � �����������
    }

    void BackToMenu()
    {
        SceneManager.LoadScene("Menu"); // ������� ��� ����� ����
    }
}