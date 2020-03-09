using UnityEngine;
using UnityEngine.UI;


public class scoreManager : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    void Update()
    {
        scoreText.text = player.position.y.ToString("0");
    }
}
