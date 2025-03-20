using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class abContr : MonoBehaviour
{
    public float moveSpeed = 1.0f; // �������� �������/������
    private XRController controller;

    private void Start()
    {
        controller = GetComponent<XRController>(); // �������� ��������� XRController
        if (controller == null)
        {
            Debug.LogError("XRController �� ������ �� �������!");
        }
    }

    private void Update()
    {
        if (controller != null)
        {
            HandleInput();
        }
    }

    private void HandleInput()
    {
        // �������� ������� ������ A
        if (controller.inputDevice.IsPressed(InputHelpers.Button.PrimaryButton, out bool isPressedA))
        {
            if (isPressedA)
            {
                MovePlayer(Vector3.up); // ��������� ������
                Debug.Log("������: ������ A ������");
            }
        }

        // �������� ������� ������ B
        if (controller.inputDevice.IsPressed(InputHelpers.Button.SecondaryButton, out bool isPressedB))
        {
            if (isPressedB)
            {
                MovePlayer(Vector3.down); // �������� ������
                Debug.Log("�����: ������ B ������");
            }
        }
    }

    private void MovePlayer(Vector3 direction)
    {
        transform.position += direction * moveSpeed * Time.deltaTime; // ������� ������
    }
}