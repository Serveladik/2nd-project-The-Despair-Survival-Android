using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawnScript : MonoBehaviour
{
    public float time = 5f;
    float timer=0f;
    public GameObject zombie;
    private Transform[] spawnPoints;
    private Transform spawnPoint;
    // Start is called before the first frame update
    public ZombieScore zScore;
    public int targetScore=15;
    public int incrementZombiesScore=15;
    void Start()
    {
        
        spawnPoints = GetComponentsInChildren<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        timer+=Time.deltaTime;
        //Debug.Log(timer);
        
        if(timer>=time)
        {
            int index=Random.Range(0,spawnPoints.Length-1);
            spawnPoint = spawnPoints[index];    
            Instantiate(zombie,spawnPoint.transform.position,spawnPoint.transform.rotation);
            timer=0f;
        }
        //REWORK TO BETTER condition (Every 15 kills)
            if(zScore.score==targetScore)
            {
                time-=1;
                targetScore+=incrementZombiesScore;
            }
        
        
        
    }
}
