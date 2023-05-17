using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonsHighlightedControll : MonoBehaviour
{
    public Animator playButtonAnimator;
    public GameObject playButton;
    public GameObject optionsButton;
    public GameObject quitButton;

    void OnMouseEnter()
    {
        // Ativa o trigger aqui
        playButtonAnimator.SetTrigger("Highlighted");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
