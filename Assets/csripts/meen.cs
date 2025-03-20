using UnityEngine;
using UnityEngine.SceneManagement; // �� ������ ����������
using System.Collections;

public class meen : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // ��������, ��� ������ � ����� "Player"
        {
            StartCoroutine(DelaySceneSwitch(0)); // �������� � 2 �������
        }
    }

    private IEnumerator DelaySceneSwitch(float delay)
    {
        yield return new WaitForSeconds(delay); // ��� ��������� �����
        SceneManager.LoadScene(0); // ������� �� ����� � �������� 1
    }
}
