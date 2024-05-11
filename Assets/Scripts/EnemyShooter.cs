using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float shootingDistance = 5f;
    public float shootingDelay = 2f;
    public float arcHeight = 1f;
    public float speed = 10f;

    private Transform target;
    private float lastShotTime;

    public bool canShoot = false;

    void Start()
    {
        // Encontrar o transform do projectile shooter
        target = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        if (target != null && canShoot)
        {
            // Verificar a distância entre o enemy e o projectile shooter            
            if (Time.time > lastShotTime + shootingDelay && GameManager.instance.IsGameRunning)
            {
                // Criar o tiro e apontá-lo para o projectile shooter
                GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
                Vector3 direction = (target.position - transform.position).normalized;
                
                // Adicionar uma força de arco para simular uma trajetória parabólica
                Vector3 arcForce = Vector3.up * arcHeight * Mathf.Abs(direction.y);
                Rigidbody projectileRb = projectile.GetComponent<Rigidbody>();
                projectileRb.AddForce((direction + arcForce) * speed, ForceMode.VelocityChange);

                // Atualizar o tempo do último tiro
                lastShotTime = Time.time;
            }
        }
    }
}
