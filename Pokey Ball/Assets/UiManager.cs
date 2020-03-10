using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public static UiManager instence;

    public GameObject lvlClear;
    public GameObject gameOver;
    public BallControl ballControl;
    public GameObject score;

    void Awake()
    {
        if (instence == null)
        {
            instence = this;
        }
    }

    public void GameStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex );
    }

    public void GamePlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }

    public void newlvl()
    {
        lvlClear.SetActive(false);
    }

    public void nextLvl()
    {
        lvlClear.SetActive(true);
        Invoke("lvlLoadtym", 1f);
    }


    public void GameOver()
    {
        gameOver.SetActive(true);
        ballControl.enabled = false;
        score.SetActive(false);
    }

    public void lvlLoadtym()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
