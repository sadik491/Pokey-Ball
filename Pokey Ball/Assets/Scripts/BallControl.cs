using UnityEngine;


public class BallControl : MonoBehaviour
{
    public Rigidbody rb;
    public float force;
    public bool gameStart;
    public Vector2 startTouchPos;
    public Vector2 endTouchPos;

    public bool triggerEnable;
   

    void Start()
    {
        gameStart = false;
        triggerEnable = false;
    }

    void Update()
    {

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                startTouchPos = Camera.main.ScreenToViewportPoint(touch.position);

            }
            else if (touch.phase == TouchPhase.Ended)
            {
                endTouchPos = Camera.main.ScreenToViewportPoint(touch.position);
            }

            if (touch.phase == TouchPhase.Ended && startTouchPos.y > endTouchPos.y && triggerEnable == false)
            {
               

                rb.AddForce(0, force * Time.deltaTime, 0);
                
                rb.useGravity = true;
                gameStart = true;
            }

            //Vector2 dis = startPos - endPos;
            //Debug.Log(dis.ToString());


            if (touch.phase == TouchPhase.Stationary && gameStart == true && triggerEnable == false)
            {
               rb.velocity = new Vector3(0, 0, 0);
               rb.useGravity = false;
            }


        }
        
    }

    public void OnTriggerEnter(Collider other)
    {
        rb.useGravity = true;
        triggerEnable = true;
        
    }

    public void OnTriggerExit(Collider other)
    {
        triggerEnable = false;
    }

}
