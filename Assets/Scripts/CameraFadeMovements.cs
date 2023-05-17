using UnityEngine;
using System.Collections;

public class CameraFadeMovements : MonoBehaviour
{
    public GameObject mainCamera;
    public float distance = 10f; // Distância da câmera ao objeto
    public float duration = 1f; // Duração da animação de afastamento ou aproximação

    private Vector3 initialPosition; // Posição inicial da câmera

    void Start()
    {
        initialPosition = transform.localPosition; // Salva a posição inicial da câmera
    }

    // Método para afastar a câmera no eixo Z local
    public void CameraZoomOut()
    {
        LeanTween.moveLocalZ(mainCamera, initialPosition.z - distance, duration)
            .setEase(LeanTweenType.easeOutQuad);
    }

    // Método para aproximar a câmera no eixo Z local
    public void CameraZoomIn()
    {
        LeanTween.moveLocalZ(mainCamera, initialPosition.z, duration)
            .setEase(LeanTweenType.easeOutQuad);
    }
}