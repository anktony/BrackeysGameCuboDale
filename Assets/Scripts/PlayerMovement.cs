using UnityEngine;

public class PlayerMovement : MonoBehaviour
{  
    public Rigidbody rb;
    public Vector3 PlayerPosition;

     

    public float forwardForce = 2000F;//apenas uma variavel.
    public float sideWaysForce = 500F;//apenas uma variavel.
    

    void Start(){}

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d")){
            rb.AddForce(sideWaysForce* Time.deltaTime, 0, 0, ForceMode.VelocityChange);  
        }

        if(Input.GetKey("a")){
            rb.AddForce(-sideWaysForce* Time.deltaTime, 0, 0, ForceMode.VelocityChange);  
        }

        
        if(rb.position.y < -1f){
            FindObjectOfType<GameManager>().EndGame();
        }

        PlayerPosition = transform.position;
    
    }
}
