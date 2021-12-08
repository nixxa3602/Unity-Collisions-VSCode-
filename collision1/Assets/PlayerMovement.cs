
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardforce= 2000f;
    public float sideforce = 500f;
    // Start is called before the first frame update
    //void Start()
    //{
       // rb.AddForce(0,200,500);
        
    //}

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardforce*Time.deltaTime);


        if (Input.GetKey("d"))
        {
            rb.AddForce(sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(sideforce*-1 * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }

        if (rb.position.y<-1f)
        {
            FindObjectOfType<GameManager>().GameOver();

        }

    }
}
