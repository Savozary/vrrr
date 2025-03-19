using UnityEngine;
using UnityEngine.UIElements;

public class DroneController : MonoBehaviour
{
    public float speed = 5f;          // �������� �����������
    public float verticalSpeed = 3f;  // �������� ������������� ��������

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
        float rotateHorizontal = Input.GetAxis("Rotate1"); // �������� �� ��� �����������
        float rotateVertical = Input.GetAxis("Rotate2");   // �������� �� ��� �����������
        transform.Rotate(rotateVertical, rotateHorizontal, 0);
    }
}