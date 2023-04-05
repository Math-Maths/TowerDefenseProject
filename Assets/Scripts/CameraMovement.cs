using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float moveDistance = 2.0f;
    public float moveDurantion = 1.0f;
    public float rotateAngle = 10.0f;
    public float rotateDuration = 5.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.moveY(gameObject, transform.position.y + moveDistance, moveDurantion).setEaseInOutSine().setLoopPingPong();
        // Configura a animação de rotação do eixo X
        LeanTween.rotateX(gameObject, transform.localEulerAngles.x + rotateAngle, rotateDuration).setEaseInOutSine().setLoopPingPong();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
