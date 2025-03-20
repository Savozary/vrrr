using UnityEngine;

public class DroneController : MonoBehaviour
{
    public float speed = 5f;          // �������� �����������
    public float verticalSpeed = 3f;  // �������� ������������� ��������
    public float rotationSpeed = 100f; // �������� ��������

    void Update()
    {
        // �������� ����� �� X � Z
        float moveHorizontal = Input.GetAxis("Horizontal"); // ����� �������� (�����-������)
        float moveVertical = Input.GetAxis("Vertical");     // ����� �������� (������-�����)
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        transform.Translate(movement * speed * Time.deltaTime, Space.World);

        // ������������ �������� (����� � ����)
        if (Input.GetButton("Fire1")) // ������ A (����� �������� �� ���� ������)
        {
            transform.Translate(Vector3.up * verticalSpeed * Time.deltaTime);
        }
        else if (Input.GetButton("Fire2")) // ������ B (����� �������� �� ���� ������)
        {
            transform.Translate(Vector3.down * verticalSpeed * Time.deltaTime);
        }

        // ��������
        float rotateHorizontal = Input.GetAxis("Mouse X"); // �������� �� ��� �����������
        float rotateVertical = Input.GetAxis("Mouse Y");   // �������� �� ��� �����������
        transform.Rotate(rotateVertical * rotationSpeed * Time.deltaTime, rotateHorizontal * rotationSpeed * Time.deltaTime, 0);
    }
}
