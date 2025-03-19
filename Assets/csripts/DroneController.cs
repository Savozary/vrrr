using UnityEngine;

public class DroneController : MonoBehaviour
{
    public float speed = 5f;        // Скорость движения
    public float liftSpeed = 3f;    // Скорость подъёма
    public float rotationSpeed = 100f; // Скорость вращения

    void Update()
    {
        // Получение ввода с контроллера VR
        float moveHorizontal = Input.GetAxis("Horizontal"); // Левый джойстик
        float moveVertical = Input.GetAxis("Vertical");     // Левый джойстик

        // Движение дрона
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        transform.Translate(movement * speed * Time.deltaTime, Space.World);

        // Вращение дрона с помощью правого джойстика
        float rotateHorizontal = Input.GetAxis("Rotate"); // Правый джойстик
        transform.Rotate(0, rotateHorizontal * rotationSpeed * Time.deltaTime, 0);

        // Контроль высоты с помощью клавиш A и B
        if (Input.GetButton("Fire1")) // Кнопка A
        {
            transform.Translate(0, liftSpeed * Time.deltaTime, 0); // Подъем
        }
        if (Input.GetButton("Fire2")) // Кнопка B
        {
            transform.Translate(0, -liftSpeed * Time.deltaTime, 0); // Спуск
        }
    }
}