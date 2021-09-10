using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatePlayer : MonoBehaviour
{
    public GameObject myPlayer;

    public bool isInstantiationNeeded = true;  

    GameObject playerPosition;

       
    void Start(){}

    void Update(){  
        InstantiatePlayerWhenCalled();
    }

    public void InstantiatePlayerWhenCalled(){
        Debug.Log(" abre Pretchex");
        if(!GameObject.Find("Player(Clone)")){
            Debug.Log("Entrou na pretchex!");
            Instantiate(myPlayer, new Vector3(0, 1, 5), Quaternion.identity);
        }
        Debug.Log(" fecha Pretchex"); 
    }

     public void ChangeInstantiationNeed(){
         isInstantiationNeeded = !isInstantiationNeeded;
    }

    void Awake() {
        Debug.Log("O chão foi chamado");
     }
}
