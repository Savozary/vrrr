using UnityEngine;
using UnityEngine.SceneManagement; // �� ������ ����������
using System.Collections;

public class exit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // ��������, ��� ������ � ����� "Player"
        {
            Application.Quit();
        }
    }
}