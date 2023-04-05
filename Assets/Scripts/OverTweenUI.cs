using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OverTweenUI : MonoBehaviour
{
    [SerializeField] GameObject blurImage, blackBGOver, strip, MainMenu, restartButton, returnButton,
    stripShadow, scoreBox, scoreTxt, scoreValue, star1, star2, star3, lightBlur, rayWheel;

    // Start is called before the first frame update
    void OnEnable()
    {
        LeanTween.alpha(blurImage.GetComponent<RectTransform>(), 1f, 2f);
        LeanTween.alpha(blackBGOver.GetComponent<RectTransform>(), 0.8f, 3f);
        LeanTween.scale(strip, new Vector3(1.0f, 1.0f, 1.0f),2f).setDelay(.5f).setEase(LeanTweenType.easeOutElastic).setOnComplete(LevelOnComplete);
        LeanTween.moveLocal(strip, new Vector3(0f, 625f, 0f),2f).setDelay(2f).setEase(LeanTweenType.easeInOutCubic);
    }

    void LevelOnComplete()
    {
        LeanTween.moveLocal(MainMenu, new Vector3(0f, 0f, 0f), 1f).setDelay(.5f).setEase(LeanTweenType.easeOutCirc).setOnComplete(StarsAnimation);
        LeanTween.scale(returnButton, new Vector3(1f, 1f, 1f), 2f).setDelay(3.8f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(restartButton, new Vector3(1f, 1f, 1f), 2f).setDelay(3.8f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(scoreTxt, new Vector3(1f, 1f, 1f), 2f).setDelay(2.5f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.alpha(scoreBox.GetComponent<RectTransform>(), 1f, 1.5f).setDelay(2.5f);
        LeanTween.alpha(scoreValue.GetComponent<RectTransform>(), 1f, 1.5f).setDelay(2.5f);
        LeanTween.alpha(stripShadow.GetComponent<RectTransform>(), 1f, 3f).setDelay(1.5f);
    }

    void StarsAnimation()
    {
        LeanTween.scale(star1, new Vector3(1f, 1f, 1f), 2f).setEase(LeanTweenType.easeOutElastic).setOnComplete(CongratsLightning);
        LeanTween.scale(star2, new Vector3(1f, 1f, 1f), 2f).setDelay(1f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(star3, new Vector3(1f, 1f, 1f), 2f).setDelay(2f).setEase(LeanTweenType.easeOutElastic);
    }

    void CongratsLightning()
    {
        LeanTween.alpha(lightBlur.GetComponent<RectTransform>(), 0.8f, 1f).setDelay(.5f);
        LeanTween.alpha(rayWheel.GetComponent<RectTransform>(), 0.8f, 1.5f).setDelay(.5f);
        
        // Obtém o ponto central do objeto "rayWheel"
        Vector3 center = rayWheel.transform.position;

        // Inicia a animação de rotação infinita do objeto "rayWheel" em torno de seu centro
        LeanTween.rotateAroundLocal(rayWheel, Vector3.forward, 360f, 12f).setLoopClamp();

        
    }
}
