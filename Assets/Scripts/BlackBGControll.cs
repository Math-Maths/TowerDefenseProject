using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class BlackBGControll : MonoBehaviour
{
    private CanvasGroup canvasGroup;
    public GameObject blackBackground;
    public float fadeDuration = 5f;
    public float delay = 1f;

    void Start()
    {
        blackBackground.SetActive(true);
        // Obter a referência do CanvasGroup
        canvasGroup = blackBackground.GetComponent<CanvasGroup>();

        // Começar com alpha igual a 1
        canvasGroup.alpha = 1;

        Invoke("FadeInAnimation", delay);    
    }

    public void FadeInAnimation()
    {
        // Alterar alpha para 0 em 5 segundos
        LeanTween.alphaCanvas(canvasGroup, 0f, fadeDuration).setEase(LeanTweenType.easeOutCubic)
        .setOnComplete(DeactivateGameObject);  
    }

    void DeactivateGameObject()
    {
        // Desativa o objeto quando a animação acabar
        LeanTween.delayedCall(gameObject, 0.1f, () => blackBackground.SetActive(false));
    }

    public void PlayOnClick()
    {
        // Ligar o BlackBG
        blackBackground.SetActive(true);
        // Executa a animação (Fade-in) do fundo preto 
        LeanTween.alphaCanvas(canvasGroup, 2.0f, 2.0f).setEase(LeanTweenType.easeOutCubic);
    }
}
