using UnityEngine;
using UnityEngine.SceneManagement; // Не забудь подключить
using System.Collections;

public class exit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Проверка, что объект с тегом "Player"
        {
            Application.Quit();
        }
    }
}