using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{ 

    // public Transform player;
    public Text scoreText;
    public GameObject player;
    

    void LateUpdate()
    {
        // scoreText.text = player.position.z.ToString("0");
        if(GameObject.Find("Player(Clone)")){
            player = GameObject.Find("Player(Clone)");
            scoreText.text = player.gameObject.GetComponent<Transform>().position.z.ToString("0");
        }
    }
}
