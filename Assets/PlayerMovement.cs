using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 2000f;

    // Fixed Update for physics updating
    public void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0 );
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        } 
            
    }
}