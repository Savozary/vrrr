using UnityEngine;
using UnityEngine.SceneManagement; // Не забудь подключить
using System.Collections;

public class ned : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("med")) // Проверка, что объект с тегом "Player"
        {
            StartCoroutine(DelaySceneSwitch(2f)); // Задержка в 2 секунды
        }
    }

    private IEnumerator DelaySceneSwitch(float delay)
    {
        yield return new WaitForSeconds(delay); // Ждём указанное время
        SceneManager.LoadScene(3); // Переход на сцену с индексом 1
    }
}