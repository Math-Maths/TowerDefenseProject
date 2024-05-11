#if UNITY_EDITOR
using UnityEditor;
#endif

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject Options;
 
    public void LoadMainScene() 
    {
        // Vai executar a cena de Gameplay após um Delay
        Invoke("LoadMyScene", 2f);
    }
    void LoadMyScene() 
    {
        // Atribui a leitura da cena de fato
        SceneManager.LoadScene("MainScene");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
   
   public void Quit()
   {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else 
        Application.Quit();
#endif
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
