using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class ZombieTarget : MonoBehaviour {

	// Use this for initialization
	
	public ZombieHP DeadStatus;
	public NavMeshAgent zombieNavMesh;
	public Transform player;
	public Transform zombie;
	public Animator zombieAnim;
	public SphereCollider sphereCollider;
    public bool inVision=false;
	public AudioClip[] zombieClip;
	public AudioSource audioOneShot;
	public AudioSource audioLooped;
	private bool isAttacking=false;
	public PauseScript pause;
	void Start()
	{
		zombie = GetComponent<Transform>();
		
	}
	public void OnTriggerEnter(Collider sphereCollider)
	{
		if(DeadStatus.isDead==false)
		{
			if(sphereCollider.gameObject.tag == "Main_Player")
			{
                this.inVision = true;
				Debug.Log("Chasing HUMAN!");

				//audioOneShot.clip = zombieClip[0];
				//audioOneShot.PlayOneShot(zombieClip[0]);
				StartCoroutine("PlayLooped");
				
				zombieAnim.SetBool("Attack",true);
			}
		}
	}
	IEnumerator PlayLooped()
	{
		
			yield return new WaitForSeconds(0f);
			audioLooped.clip = zombieClip[1];
			audioLooped.Play();	
		
		
		
	}
		void Update()
	{
	
        if(this.inVision==true)
        {
			
            zombieNavMesh.SetDestination(player.position);
			
        }
		
		
		if (DeadStatus.isDead==true)
		{

			//zombieNavMesh.SetDestination(zombie.position);
			isAttacking=false;
			zombieAnim.SetBool("Attack",false);
		}
	}
	
}
