using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatePlayer : MonoBehaviour
{
    public GameObject myPlayer; 

    GameObject playerPosition;

       
    void Start(){}

    void Update(){  
        InstantiatePlayerWhenCalled();
    }

    public void InstantiatePlayerWhenCalled(){
            if(!GameObject.Find("Player(Clone)")){
            Debug.Log("Summonando player...");
            Instantiate(myPlayer, new Vector3(0, 1, 5), Quaternion.identity);
        } 
    }

}
