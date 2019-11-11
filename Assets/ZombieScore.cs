using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ZombieScore : MonoBehaviour
{
    public Text zombieScore;
    public int score=0;
    // Start is called before the first frame update
    void Start()
    {
        zombieScore=GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {  
        zombieScore.text = "Zombies dead: " + score.ToString();
    }
}
