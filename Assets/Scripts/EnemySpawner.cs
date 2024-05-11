using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float minDistance = 10.0f;
    public float spawnDelay = 1.0f;
    public float minSpawnDelay = 1.0f;
    public float descreaseDelayAmount = .02f;
    public float maxX = 10.0f;
    public float maxZ = 10.0f;
    public Transform projectileShooter;

    private float timeUntilNextSpawn;

    private void Start()
    {
        timeUntilNextSpawn = spawnDelay;
    }

    private void Update()
    {
        timeUntilNextSpawn -= Time.deltaTime;

        if (timeUntilNextSpawn <= 0 && GameManager.instance.IsGameRunning)
        {
            SpawnEnemy();
        }
    }

    void SpawnEnemy()
    {

        int numberSide = Random.Range(1,3);
        float zPos = 0;

        if(numberSide == 1)
        {
            zPos = maxZ;
        }
        else if(numberSide == 2)
        {
            zPos = -maxZ;
        }

        Vector3 randomPosition = new Vector3(Random.Range(-maxX, maxX), 0.6f, zPos);

        // Verificar se a distância mínima entre a posição aleatória e o spawner é suficiente
        float distance = Vector3.Distance(randomPosition, transform.position);
        if (distance >= minDistance)
        {
            GameObject enemy = Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
            // Definir o projectile shooter como alvo do inimigo
            Enemy enemyScript = enemy.GetComponent<Enemy>();
            enemyScript.projectileShooter = projectileShooter;
            
            timeUntilNextSpawn = spawnDelay;
        }

        if(spawnDelay > minSpawnDelay)
        {
            spawnDelay -= descreaseDelayAmount;
        }
    }
}
