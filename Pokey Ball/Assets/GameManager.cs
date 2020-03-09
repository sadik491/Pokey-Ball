
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instence;

    void Awake()
    {
        if (instence == null)
        {
            instence = this;
        }
    }
    public void gameStart()
    {
        
    }

    
    public void gameOver()
    {
        
    }

    public void restart()
    {
        UiManager.instence.GameStart();
    }
}
