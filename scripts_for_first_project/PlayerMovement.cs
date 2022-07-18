using UnityEngine;

public class PlayerMovement : MonoBehaviour{
    
    // This is a reference to the Rigibody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // I marked this as "Fixed"Update
    // Because I am using it to mess with physics
    void FixedUpdate() 
    {
        // add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); 

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a")) 
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {

            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
