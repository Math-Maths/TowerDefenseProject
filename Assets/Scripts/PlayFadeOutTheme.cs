using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayFadeOutTheme : MonoBehaviour
{
   public Animator animator;
   public AudioSource audioSource;

   public void PlayFadeOut()
   {
      animator.SetTrigger("PlayFadeOut");
      //animator.SetBool("LoopCheck", true);
      //Invoke("PauseAudio", 2f);
   }
}
