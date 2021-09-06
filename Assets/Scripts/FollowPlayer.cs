using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
//    public Transform player;
   public Vector3 offset;

   public GameObject player;

    

   void Start(){
   }

    void Update()
    {   
        
        // transform.position = player.position + offset;
       if(GameObject.Find("Player(Clone)")){
            player = GameObject.Find("Player(Clone)");
            transform.position = player.gameObject.GetComponent<Transform>().position + offset;
       };
      
               
    }
    
         
        

}
