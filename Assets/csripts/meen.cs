using UnityEngine;
using UnityEngine.SceneManagement; // Не забудь подключить
using System.Collections;

public class meen : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Проверка, что объект с тегом "Player"
        {
            StartCoroutine(DelaySceneSwitch(0)); // Задержка в 2 секунды
        }
    }

    private IEnumerator DelaySceneSwitch(float delay)
    {
        yield return new WaitForSeconds(delay); // Ждём указанное время
        SceneManager.LoadScene(0); // Переход на сцену с индексом 1
    }
}
