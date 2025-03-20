using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LaserPointerController : MonoBehaviour
{
    public XRController controller; // Привязка контроллера
    public LineRenderer lineRenderer; // Привязка LineRenderer
    public float maxDistance = 10f;   // Максимальная длина лазера

    void Update()
    {
        // Проверка нажатия кнопки для активации лазера
        if (controller.inputDevice.TryGetFeatureValue(UnityEngine.XR.CommonUsages.triggerButton, out bool isPressed) && isPressed)
        {
            // Включение лазера
            lineRenderer.enabled = true;

            RaycastHit hit;
            Vector3 origin = controller.transform.position;
            Vector3 direction = controller.transform.forward;

            if (Physics.Raycast(origin, direction, out hit, maxDistance))
            {
                lineRenderer.SetPosition(0, origin);
                lineRenderer.SetPosition(1, hit.point);

                // Проверка нажатия на объект
                if (hit.collider != null && hit.collider.CompareTag("Interactable"))
                {
                    // Здесь можно добавить логику для взаимодействия
                    if (Input.GetButtonDown("Fire1")) // Используйте нужную кнопку
                    {
                        Debug.Log("Clicked on " + hit.collider.name);
                        // Взаимодействие с объектом
                    }
                }
            }
            else
            {
                lineRenderer.SetPosition(0, origin);
                lineRenderer.SetPosition(1, origin + direction * maxDistance);
            }
        }
        else
        {
            // Отключение лазера, если кнопка не нажата
            lineRenderer.enabled = false;
        }
    }
}