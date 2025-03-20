using UnityEngine;

public class trigger : MonoBehaviour
{
    public GameObject objectToSpawn; // Префаб объекта для спавна

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
        // Спавн объекта на месте триггера
        Instantiate(objectToSpawn, transform.position, transform.rotation);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Нажми пробел для создания объекта
        {
            Instantiate(objectToSpawn, transform.position, transform.rotation);
        }
    }
}