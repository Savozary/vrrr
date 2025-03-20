using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class abContr : MonoBehaviour
{
    public float moveSpeed = 1.0f; // Скорость подъема/спуска
    private XRController controller;

    private void Start()
    {
        controller = GetComponent<XRController>(); // Получаем компонент XRController
        if (controller == null)
        {
            Debug.LogError("XRController не найден на объекте!");
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
        // Проверка нажатия кнопки A
        if (controller.inputDevice.IsPressed(InputHelpers.Button.PrimaryButton, out bool isPressedA))
        {
            if (isPressedA)
            {
                MovePlayer(Vector3.up); // Поднимаем игрока
                Debug.Log("Подъем: Кнопка A нажата");
            }
        }

        // Проверка нажатия кнопки B
        if (controller.inputDevice.IsPressed(InputHelpers.Button.SecondaryButton, out bool isPressedB))
        {
            if (isPressedB)
            {
                MovePlayer(Vector3.down); // Опускаем игрока
                Debug.Log("Спуск: Кнопка B нажата");
            }
        }
    }

    private void MovePlayer(Vector3 direction)
    {
        transform.position += direction * moveSpeed * Time.deltaTime; // Двигаем игрока
    }
}