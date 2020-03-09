using UnityEngine;

public class finish : MonoBehaviour
{
    

    public void OnCollisionEnter(Collision collision)
    {
        UiManager.instence.GameOver();
    }
}
