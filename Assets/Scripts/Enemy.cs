using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 1.0f;
    public float stopDistance = 2.0f;
    public Transform projectileShooter;
    public Plane plane;

    private void Start()
    {
        plane = new Plane(transform.up, transform.position);
    }

    private void Update()
    {
        // Calcular a direção do movimento ignorando a altura do projectile shooter
        Vector3 direction = (projectileShooter.position - transform.position).normalized;
        Vector3 projectedDirection = Vector3.ProjectOnPlane(direction, plane.normal);

        // Verificar a distância entre o inimigo e o projectile shooter
        float distance = Vector3.Distance(transform.position, projectileShooter.position);

        // Se a distância for maior que a distância de parada, mover o inimigo
        if (distance > stopDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, transform.position + projectedDirection, speed * Time.deltaTime);
            transform.rotation = Quaternion.LookRotation(projectedDirection, transform.up);
        }
    }
}
