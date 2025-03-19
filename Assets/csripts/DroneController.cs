using UnityEngine;

public class DroneController : MonoBehaviour
{
    public float speed = 5f;        // �������� ��������
    public float liftSpeed = 3f;    // �������� �������
    public float rotationSpeed = 100f; // �������� ��������

    void Update()
    {
        // �������� �����
        float moveHorizontal = Input.GetAxis("Horizontal"); // ����� ��������
        float moveVertical = Input.GetAxis("Vertical");     // ����� ��������
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        transform.Translate(movement * speed * Time.deltaTime, Space.World);

        // �������� �����
        float rotateHorizontal = Input.GetAxis("Rotate"); // ������ ��������
        transform.Rotate(0, rotateHorizontal * rotationSpeed * Time.deltaTime, 0);

        // �������� ������
        if (Input.GetButton("Fire1")) // ������ A
        {
            transform.Translate(0, liftSpeed * Time.deltaTime, 0); // ������
        }
        if (Input.GetButton("Fire2")) // ������ B
        {
            transform.Translate(0, -liftSpeed * Time.deltaTime, 0); // �����
        }
    }
}