using UnityEngine;

public class FollowCam : MonoBehaviour
{

    public GameObject ball;
    public Vector3 offset;
    void Update()
    {
        transform.position = ball.transform.position + offset;
    }
}
