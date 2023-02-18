using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionInstatiantor : MonoBehaviour
{
    public GameObject explosionPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        }
    }
}
