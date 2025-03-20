using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LaserPointerController : MonoBehaviour
{
    public XRController controller; // �������� �����������
    public LineRenderer lineRenderer; // �������� LineRenderer
    public float maxDistance = 10f;   // ������������ ����� ������

    void Update()
    {
        // �������� ������� ������ ��� ��������� ������
        if (controller.inputDevice.TryGetFeatureValue(UnityEngine.XR.CommonUsages.triggerButton, out bool isPressed) && isPressed)
        {
            // ��������� ������
            lineRenderer.enabled = true;

            RaycastHit hit;
            Vector3 origin = controller.transform.position;
            Vector3 direction = controller.transform.forward;

            if (Physics.Raycast(origin, direction, out hit, maxDistance))
            {
                lineRenderer.SetPosition(0, origin);
                lineRenderer.SetPosition(1, hit.point);

                // �������� ������� �� ������
                if (hit.collider != null && hit.collider.CompareTag("Interactable"))
                {
                    // ����� ����� �������� ������ ��� ��������������
                    if (Input.GetButtonDown("Fire1")) // ����������� ������ ������
                    {
                        Debug.Log("Clicked on " + hit.collider.name);
                        // �������������� � ��������
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
            // ���������� ������, ���� ������ �� ������
            lineRenderer.enabled = false;
        }
    }
}