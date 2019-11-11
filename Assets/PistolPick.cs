using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PistolPick : MonoBehaviour
{
    public WeaponSwitch weaponSwitch;
    public GameObject groundedPistol;
    public Text pickPistolText;
    public GameObject LeftHand;
    public GameObject RightHand;
    public GameObject PistolHands;
    public AudioClip[] ShotClips;
    public AudioSource audio;
    public Text pistolPickedText;
    public Animator pistolTextAnim;
    // Start is called before the first frame update
   void Update()
   {
       

        if(pickPistolText.enabled == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                groundedPistol.SetActive(false);
                pickPistolText.enabled = false;
                weaponSwitch.PistolAllow=true;
                audio.clip = ShotClips[0];
				audio.PlayOneShot(audio.clip);

                pistolPickedText.text = "Pistol recieved";
                pistolTextAnim.SetBool("PistolPicked",true);

                if(this.pistolTextAnim.GetCurrentAnimatorStateInfo(0).IsName("PistolTextAnim"))
 		        {
			        pistolPickedText.enabled = false;
			        //pistolTextAnim.SetBool("PickedUp",false);
		        }
                LeftHand.SetActive(false);
                RightHand.SetActive(false);
                PistolHands.SetActive(true);

            }
        }
   }
    
    // Update is called once per frame
    void OnTriggerStay(Collider player)
    {
        if(player.gameObject.tag == "Main_Player")
        {
            pickPistolText.enabled = true;
        }
        
    }

    void OnTriggerExit(Collider player)
    {
        if(player.gameObject.tag == "Main_Player")
        {
            pickPistolText.enabled = false;
            
        }
    }
    
}
