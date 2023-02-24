using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyinstantiator : MonoBehaviour
{
   public GameObject DestroyPrefab;

   public GameObject Bomb;

   public Transform DestroyTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(DestroyPrefab, DestroyTransform.position, DestroyTransform.rotation);
             
        }
    }   

     private void OnCollisionEnter(Collision Bomb)
    {
        // verifica se ocorreu uma colisão com outro objeto
        if (Bomb.gameObject.CompareTag("Player"))
        {
            Debug.Log("Colisão com objeto de tag Player!");
            // Adicione aqui o código que você deseja executar quando ocorrer a colisão
        }
    } 
}
