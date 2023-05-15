using UnityEngine;

public class ShateredEnemy : MonoBehaviour
{

    [SerializeField]
    Transform objectCenter;
    Rigidbody rb;

    [SerializeField]
    float minExplosion = 5f;
    [SerializeField]
    float maxExplosion = 10f;
    [SerializeField]
    float torqueForce = 10f;

    float timeToDisappear = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        Vector3 direction = transform.position - objectCenter.position;
        float explosionForce = Random.Range(minExplosion, maxExplosion);

        rb.AddForce(direction * explosionForce, ForceMode.Impulse);
        rb.AddTorque(RandomToque(), RandomToque(), RandomToque(), ForceMode.Impulse);

        Destroy(transform.parent.gameObject, timeToDisappear);
        //Destroy(gameObject, timeToDisappear);
    }

    float RandomToque()
    {
        return Random.Range(-torqueForce, torqueForce);
    }
}