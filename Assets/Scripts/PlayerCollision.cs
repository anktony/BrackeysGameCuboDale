
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    

    void OnCollisionEnter(Collision collisionInfo){

       if(collisionInfo.collider.tag == "Obstacle"){
          Debug.Log("We hit an Obstacle!") ;
          movement.enabled = false;// mesma coisa de GetComponent<PlayerMovement>().enabled = false;
          FindObjectOfType<GameManager>().EndGame();

       }
        
   }
}