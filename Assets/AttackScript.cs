using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AttackScript : MonoBehaviour
{
    public GameOverBool gameOverBoolScript;
    private Transform zombiePos;
    public Transform playerPos;
    public GameObject player;
    private NavMeshAgent zombie;
    private Animator zombieAnimator;
    public float distance;
    public CameraScript mLook;
    public FirstPersonControllerFix fController;
    //public WeaponSwitch wSwitch;
    public GameObject armL;
    
    private AttackScript zombieObj;
    public LavaDamageScript deadBool;
    // Start is called before the first frame update
    void Start()
    {
        zombieObj = GetComponent<AttackScript>();
        zombieAnimator = GetComponent<Animator>();
        zombie = GetComponent<NavMeshAgent>();
        zombiePos = gameObject.GetComponent<Transform>();
        playerPos = player.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance (gameObject.transform.position, player.transform.position);
        //Debug.Log(distance);
        if(distance<=4)
        {
            zombieAnimator.SetBool("ZombieAttack",true);
        }
        if(distance>=7)
        {
            zombieAnimator.SetBool("ZombieAttack",false);
        }
        if(distance<=3)
        {
            mLook.enabled=false;
            fController.enabled=false;
            //wSwitch.enabled=false;

            armL.SetActive(false);
            //armR.SetActive(false);
            //armP.SetActive(false);
            

            gameOverBoolScript.GameOver=true;
            this.zombieObj.enabled=false;
            deadBool.dead=true;
            Debug.Log("DEAD!");
        }
        
    }
}
