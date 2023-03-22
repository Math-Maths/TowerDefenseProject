using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenSettings : MonoBehaviour
{
    public GameObject BlackBGSet;
    public GameObject SetWindow;
    private CanvasGroup canvasGroup;
    public float delay = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        canvasGroup = BlackBGSet.GetComponent<CanvasGroup>();
        canvasGroup.alpha = 0;
    }

    public void PlayOnOptions()
    {
        // Ativa o Objeto
        BlackBGSet.SetActive(true);
        // Executa a animação (Fade-in) do fundo preto atras
        LeanTween.alphaCanvas(canvasGroup, 1f, 1.5f).setEase(LeanTweenType.easeOutCubic);

        // Define a posição final do objeto na tela
        Vector3 finalPosition = new Vector3(0f, 0f, 0f); 

        // Define a posição inicial do objeto abaixo da tela
        Vector3 startPosition = new Vector3(0f, -Screen.height/2f, 0f); 

        // Move o objeto de sua posição inicial para sua posição final com a animação desejada
        SetWindow.transform.localPosition = startPosition;
        SetWindow.LeanMoveLocal(finalPosition, 0.5f).setEaseOutExpo().delay = 0.1f;
    }

    public void PlayOnBackButton()
    {
        LeanTween.alphaCanvas(canvasGroup, 0f, 1.5f).setEaseInExpo();

        // Define a posição final do objeto na tela
        Vector3 finalPosition = new Vector3(0f, 0f, 0f); 
        // Move o objeto para baixo no eixo Y
        SetWindow.LeanMoveLocalY(-Screen.height, 1.0f).setEaseInExpo();
        Invoke("DesactiveBlackBG", 2.0f);
    }

    void DesactiveBlackBG()
    {
        BlackBGSet.SetActive(false);
    }
}
