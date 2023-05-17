using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject pauseBlackBG;
    public GameObject pauseBlurImage;
    public Animator animator;
    public Animator animatorBlackBG;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
                
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        pauseBlackBG.SetActive(false);
        pauseBlurImage.SetActive(false);

        GameIsPaused = false;
        Time.timeScale = 1f;
        animator.SetTrigger("UIScaleFadeOut");
    }
    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        pauseBlackBG.SetActive(true);
        pauseBlurImage.SetActive(true);
        
        GameIsPaused = true;
        Time.timeScale = 0f;
        animator.SetTrigger("UIScaleFadeIn");
    }

    public void ReturnToMenu()
    {
        Time.timeScale = 1f;
        
        //animator.SetTrigger("FadeInReturn");
        Invoke("LoadMenuScene", 1.5f);
        
    }
    void LoadMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
