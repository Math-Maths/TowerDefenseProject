using System.Collections;
using UnityEngine;

public class ProjectileShooter : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float launchForce = 10f;
    public float upForce = 1f;
    public float distanceAdjust = 10f;
    public float fireDelay = 1.0f;
    private float lastFireTime = 0.0f;

    private Plane groundPlane;

    private void Start()
    {
        groundPlane = new Plane(Vector3.up, Vector3.zero);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time > lastFireTime + fireDelay)
        {
            ShootProjectile();
            lastFireTime = Time.time;
        }
    }

    private void ShootProjectile()
    {
        // Instanciar o prefab do projétil
        GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);

        // Calcular a posição do cursor do mouse
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        // Calcular a interseção com o plano
        float enter;
        if (groundPlane.Raycast(ray, out enter))
        {
            Vector3 target = ray.GetPoint(enter);

            // Calcular a direção da trajetória do projétil
            Vector3 direction = (target - transform.position + (Vector3.up * upForce)).normalized;

            float distance = Vector3.Distance(transform.position, target);

            // Ajustar a força de lançamento baseada na distância
            float adjustedLaunchForce = launchForce * (distance / distanceAdjust);

            // Aplicar a força de lançamento na direção da trajetória
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.AddForce(direction * adjustedLaunchForce, ForceMode.Impulse);
        }
    }
}
