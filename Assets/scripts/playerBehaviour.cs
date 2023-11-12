using UnityEngine;

public class playerBehaviour : MonoBehaviour
{

public Rigidbody rb;
public float forwardforce=2000f;
public float sideforce=1000f;

    
    void FixedUpdate()
    {
        //check if the key is pressed, it return true if it is preede else false
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(0, 0, forwardforce * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(0, 0, -forwardforce * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
             rb.AddForce(sideforce*Time.deltaTime,0,0);

        }
         if(Input.GetKey(KeyCode.LeftArrow))
        {
             rb.AddForce(-sideforce*Time.deltaTime,0,0);

        } 
         if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
         
    }
}
