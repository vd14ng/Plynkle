using UnityEngine;

public class Game : MonoBehaviour
{
    public UI Ui; 
    private static bool isGameStarted = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Ui.ShowStartScreen();
    }

    public void OnStartButtonClick()
    {
        Ui.HideStartScreen();
        isGameStarted = true;
    }

    public static bool IsGameNotStarted()
    {
        return !isGameStarted;
    }

    public static bool IsGameStarted()
    {
        return isGameStarted;
    }
    
}
