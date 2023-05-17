using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject Options;
    public Animator animator;
 
    public void LoadMainScene()
    {
        // Vai executar a cena de Gameplay após um Delay
        Invoke("LoadMyScene", 2f);
        animator.SetBool("LoopCheck", true);
        animator.SetTrigger("PlayFadeOut");
    }
    void LoadMyScene() 
    {
        // Atribui a leitura da cena de fato
        SceneManager.LoadScene("MainScene");
    }

    public void LoadMainMenu()
    {
        Invoke("MainMenuDelayed", 2f);
    }

    void MainMenuDelayed()
    {
     SceneManager.LoadScene("MainMenu");
    }
   
   public void Quit()
   {
        Debug.Log("Sair do jogo");
        Application.Quit();
   }

   public void OpenOptions()
   {
        // MainMenu.SetActive(false);
        Options.SetActive(true);
   }

   public void CloseOptions()
   {
        Invoke("TweenOptions", 1.0f);
   }

   void TweenOptions()
   {
        Options.SetActive(false);
        //MainMenu.SetActive(true);
   }
}
