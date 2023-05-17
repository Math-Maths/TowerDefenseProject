using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanWavesSounds : MonoBehaviour
{
    public Animator animator;
    public AudioSource audioSource;

    public void ReturnFadeOut()
    {
        animator.SetTrigger("ReturnFadeOut");
    }

    // Start is called before the first frame update
    void Start()
    {
        Invoke("StartFadeIn", .5f);
    }

    void StartFadeIn()
    {
        audioSource.Play();
    }
}
