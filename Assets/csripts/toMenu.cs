using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class toMenu : MonoBehaviour

{
    public Button backButton;

    // Start is called before the first frame update
    void Start()
    {
        backButton.onClick.AddListener(BackToMenu);
    }

    // Update is called once per frame
    void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
