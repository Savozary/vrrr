using UnityEngine;
using UnityEngine.SceneManagement; // �� ������ ����������
using System.Collections;

public class ned : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("med")) // ��������, ��� ������ � ����� "Player"
        {
            StartCoroutine(DelaySceneSwitch(2f)); // �������� � 2 �������
        }
    }

    private IEnumerator DelaySceneSwitch(float delay)
    {
        yield return new WaitForSeconds(delay); // ��� ��������� �����
        SceneManager.LoadScene(3); // ������� �� ����� � �������� 1
    }
}