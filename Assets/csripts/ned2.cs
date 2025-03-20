using UnityEngine;
using UnityEngine.SceneManagement; // �� ������ ����������
using System.Collections;

public class ned2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // ��������, ��� ������ � ����� "Player"
        {
            StartCoroutine(DelaySceneSwitch(2f)); // �������� � 2 �������
        }
    }

    private IEnumerator DelaySceneSwitch(float delay)
    {
        yield return new WaitForSeconds(delay); // ��� ��������� �����
        SceneManager.LoadScene(4); // ������� �� ����� � �������� 1
    }
}