using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    bool _isGameRunning;

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
    
        instance = this;
        DontDestroyOnLoad(gameObject);

        _isGameRunning = true;
    }

    public bool IsGameRunning
    {
        get{return _isGameRunning;}
    }

    public void GameState(bool state)
    {
        _isGameRunning = state;
    }

}