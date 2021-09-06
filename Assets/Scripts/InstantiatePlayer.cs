using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatePlayer : MonoBehaviour
{
    public GameObject myPlayer;

    public bool isInstantiationNeeded = true;  

    GameObject playerPosition;

       
    void Start()
    {   
           InstantiatePlayerWhenCalled();
        
    }
    void Update()
    {    }

    public void InstantiatePlayerWhenCalled(){
        Debug.Log(" abre Pretchex");
        Instantiate(myPlayer, new Vector3(0, 1, 5), Quaternion.identity);
        Debug.Log(" fecha Pretchex");
        
     }

     public void ChangeInstantiationNeed(){
         isInstantiationNeeded = !isInstantiationNeeded;
     }

    void Awake() {
        Debug.Log("O chão foi chamado");
     }
}
