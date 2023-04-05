using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBarControl : MonoBehaviour
{
    [SerializeField] private Image lifeBarImage;
    private Transform myCamera;

    private void Awake()
    {
        myCamera = Camera.main.transform;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(transform.position + myCamera.forward);
    }
    public void LifeBarChange(int currentHealth, int maxHealth)
    {
        lifeBarImage.fillAmount = (float) currentHealth / maxHealth;
    }
}
