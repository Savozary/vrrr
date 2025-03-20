using UnityEngine;

public class trigger : MonoBehaviour
{
    public GameObject objectToSpawn; // ������ ������� ��� ������

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered trigger with: " + other.gameObject.name);

        if (other.gameObject.CompareTag("Player"))
        {
            SpawnObject();
        }
    }

    private void SpawnObject()
    {
        // ����� ������� �� ����� ��������
        Instantiate(objectToSpawn, transform.position, transform.rotation);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // ����� ������ ��� �������� �������
        {
            Instantiate(objectToSpawn, transform.position, transform.rotation);
        }
    }
}