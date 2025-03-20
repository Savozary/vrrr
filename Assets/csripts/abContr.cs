using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class ControllerInput : MonoBehaviour
{
    public float moveSpeed = 1.0f; // �������� �������/������
    private XRController controller;

    void Start()
    {
        controller = GetComponent<XRController>(); // �������� ��������� XRController
        if (controller == null)
        {
            Debug.LogError("XRController �� ������ �� �������!");
        }
    }

    void Update()
    {
        if (controller != null)
        {
            HandleInput();
        }
    }

    private void HandleInput()
    {
        // �������� ������� ������ A
        if (controller.inputDevice.IsPressed(InputHelpers.Button.PrimaryButton, out bool isPressedA) && isPressedA)
        {
            MoveObject(Vector3.up); // ��������� ������
        }

        // �������� ������� ������ B
        if (controller.inputDevice.IsPressed(InputHelpers.Button.SecondaryButton, out bool isPressedB) && isPressedB)
        {
            MoveObject(Vector3.down); // �������� ������
        }
    }

    private void MoveObject(Vector3 direction)
    {
        transform.position += direction * moveSpeed * Time.deltaTime; // ������� ������
    }
}