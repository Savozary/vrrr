using UnityEngine;

public class DroneController : MonoBehaviour
{
    public float speed = 5f;          // Скорость перемещения
    public float verticalSpeed = 3f;  // Скорость вертикального движения
    public float rotationSpeed = 100f; // Скорость поворота

    void Update()
    {
        // Движение дрона по X и Z
        float moveHorizontal = Input.GetAxis("Horizontal"); // Левый джойстик (влево-вправо)
        float moveVertical = Input.GetAxis("Vertical");     // Левый джойстик (вперед-назад)
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        transform.Translate(movement * speed * Time.deltaTime, Space.World);

        // Вертикальное движение (вверх и вниз)
        if (Input.GetButton("Fire1")) // Кнопка A (можно изменить на вашу кнопку)
        {
            transform.Translate(Vector3.up * verticalSpeed * Time.deltaTime);
        }
        else if (Input.GetButton("Fire2")) // Кнопка B (можно изменить на вашу кнопку)
        {
            transform.Translate(Vector3.down * verticalSpeed * Time.deltaTime);
        }

        // Вращение
        float rotateHorizontal = Input.GetAxis("Mouse X"); // Замените на оси контроллера
        float rotateVertical = Input.GetAxis("Mouse Y");   // Замените на оси контроллера
        transform.Rotate(rotateVertical * rotationSpeed * Time.deltaTime, rotateHorizontal * rotationSpeed * Time.deltaTime, 0);
    }
}
