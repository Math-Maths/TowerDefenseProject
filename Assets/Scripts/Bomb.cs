using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject explosionPrefab;

    public LayerMask explosionLayer;

    public Vector3 scaleIndex = new Vector3(1,1,1);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -10) Destroy(gameObject);
    }

    void OnTriggerEnter(Collider other) 
    {
        if(explosionLayer != (explosionLayer | (1 << other.gameObject.layer)))
        {
            GameObject explosionSize = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            explosionSize.transform.localScale= scaleIndex;
            Destroy(gameObject);
        }
    }
}
