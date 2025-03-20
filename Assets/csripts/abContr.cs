using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class ControllerInput : MonoBehaviour
{
    public float moveSpeed = 1.0f; // Скорость подъема/спуска
    private XRController controller;

    void Start()
    {
        controller = GetComponent<XRController>(); // Получаем компонент XRController
        if (controller == null)
        {
            Debug.LogError("XRController не найден на объекте!");
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
        // Проверка нажатия кнопки A
        if (controller.inputDevice.IsPressed(InputHelpers.Button.PrimaryButton, out bool isPressedA) && isPressedA)
        {
            MoveObject(Vector3.up); // Поднимаем объект
        }

        // Проверка нажатия кнопки B
        if (controller.inputDevice.IsPressed(InputHelpers.Button.SecondaryButton, out bool isPressedB) && isPressedB)
        {
            MoveObject(Vector3.down); // Опускаем объект
        }
    }

    private void MoveObject(Vector3 direction)
    {
        transform.position += direction * moveSpeed * Time.deltaTime; // Двигаем объект
    }
}