using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaDamageScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameOverBool gameOver;
    public bool dead=false;
    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider player)
    {
        if(player.gameObject.tag == "Main_Player")
        {
            dead=true;
            gameOver.GameOver=true;
        }
    }
}
