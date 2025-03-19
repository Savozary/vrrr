using UnityEngine;

public class DroneController : MonoBehaviour
{
    public float speed = 5f;        // Скорость движения
    public float liftSpeed = 3f;    // Скорость подъёма
    public float rotationSpeed = 100f; // Скорость вращения

    void Update()
    {
        // Движение дрона
        float moveHorizontal = Input.GetAxis("Horizontal"); // Левый джойстик
        float moveVertical = Input.GetAxis("Vertical");     // Левый джойстик
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        transform.Translate(movement * speed * Time.deltaTime, Space.World);

        // Вращение дрона
        float rotateHorizontal = Input.GetAxis("Rotate"); // Правый джойстик
        transform.Rotate(0, rotateHorizontal * rotationSpeed * Time.deltaTime, 0);

        // Контроль высоты
        if (Input.GetKey(KeyCode.JoystickButton0)) // Кнопка A
        {
            transform.Translate(0, liftSpeed * Time.deltaTime, 0); // Подъем
        }
        if (Input.GetKey(KeyCode.JoystickButton1)) // Кнопка B
        {
            transform.Translate(0, -liftSpeed * Time.deltaTime, 0); // Спуск
        }
    }
}