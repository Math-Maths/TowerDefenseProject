using UnityEngine;

public class RotateObject : MonoBehaviour
{
    private void RotateTowardsMouse()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Vector3 lookPos = hit.point - transform.position;
            lookPos.y = 0; // define o eixo y como zero
            Quaternion rotation = Quaternion.LookRotation(lookPos);
            Vector3 euler = rotation.eulerAngles;
            euler.x = transform.rotation.eulerAngles.x;
            euler.z = transform.rotation.eulerAngles.z;
            transform.rotation = Quaternion.Euler(euler);
        }
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RotateTowardsMouse();
        }
    }
}
