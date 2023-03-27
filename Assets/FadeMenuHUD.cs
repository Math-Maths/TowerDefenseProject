using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeMenuHUD : MonoBehaviour
{
    public CanvasGroup logoTitle;
    public CanvasGroup mainMenu;
    public float animationDuration = 1f;

    public void PlayOnOptions()
    {
        // Inicializa o valor do alpha para 1
        mainMenu.alpha = 1;
        logoTitle.alpha = 1;

        // Define o valor final do alpha para 0
        float finalAlpha = 0;

        // Cria e inicia a animação usando LeanTween
        LeanTween.alphaCanvas(mainMenu, finalAlpha, animationDuration);
        LeanTween.alphaCanvas(logoTitle, finalAlpha, animationDuration);
    }

    public void PlayOnBackButton()
    {
        // Inicializa o valor do alpha para 0
        mainMenu.alpha = 0;
        logoTitle.alpha = 0;

        // Define o valor final do alpha para 1
        float finalAlpha = 1;

        // Cria e inicia a animação usando LeanTween
        LeanTween.alphaCanvas(mainMenu, finalAlpha, animationDuration);
        LeanTween.alphaCanvas(logoTitle, finalAlpha, animationDuration);
    }
}
