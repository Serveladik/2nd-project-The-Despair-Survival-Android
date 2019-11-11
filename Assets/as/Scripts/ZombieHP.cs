using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class ZombieHP : MonoBehaviour {

	// Use this for initialization
	public int zombiesDeadScore=0;
	public float zombieHealth;
    public GameObject Zombie;
    //public save_script save;
	public bool isDead;
	Animator zombieAnimator;
	public NavMeshAgent navMesh;
	public AudioSource soundSource;
	public AudioClip[] audioClip;
	private AudioSource audioLooped;
	public ZombieScore scoreScript;
    void Start () 
	{
		//this.audio=GetComponentInChildren<AudioSource>();
		this.audioLooped=GetComponentInChildren<AudioSource>();
		this.navMesh = GetComponent<NavMeshAgent>();
		this.zombieHealth = 60f;
		this.zombieAnimator = GetComponent<Animator>();
	}
void ZombieDeadSounds()
{
	this.soundSource.clip = audioClip[Random.Range(0,audioClip.Length)];
	this.soundSource.PlayOneShot(soundSource.clip);
	
}
	void Update()
	{
       if(Time.timeScale==0)
	   {
		   audioLooped.mute=true;
	   }
	   else
	   {
		   audioLooped.mute=false;
	   }
        if (this.zombieHealth==0 || this.zombieHealth==-30)
			{
            	//Set Animatior
            	//Zombie.SetActive(false);
				this.zombieAnimator.SetBool("Die",true);
            	this.isDead=true;
            	this.navMesh.isStopped=true;
				this.audioLooped.enabled=false;
				ZombieDeadSounds();
				this.zombieHealth-=1;
				scoreScript.score+=1;
				StartCoroutine("DeleteZombie");
        	}	
	}
	void ZombieHealth(float weaponDamage)
	{
		zombieHealth -= weaponDamage;	
	}
IEnumerator DeleteZombie()
{
	yield return new WaitForSeconds(10f);
	Destroy(Zombie);	
	
}

}