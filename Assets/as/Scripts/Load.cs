using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load : MonoBehaviour {

    public Transform Cur_play_position;
    public BulletsScipt bulletsScipt;
    public save_script save;
    Animator Zombie_dead;
    public void Start()
    {
        //Transform Cur_play_position = this.gameObject.transform;
        //Vector3 Player_Position = new Vector3(PlayerPrefs.GetFloat("PosX"), PlayerPrefs.GetFloat("PosY"), PlayerPrefs.GetFloat("PosZ"));
        //bulletsScipt.BulletsInClip = PlayerPrefs.GetInt("BulletsInClip");
        //bulletsScipt.BulletsInClip = PlayerPrefs.GetInt("BulletsInClip");
        //Cur_play_position.position = Player_Position;
        //save.num = PlayerPrefs.GetInt("Num");
        //save.index = PlayerPrefs.GetInt("Index_");




        //for (int i = 0; i < save.num; i++)
        //{

        //    GameObject zombies = GameObject.Find(PlayerPrefs.GetString("Name_zombies" + i));
        //    GameObject.Find(PlayerPrefs.GetString("Name_zombies" + i)).transform.position = new Vector3(PlayerPrefs.GetFloat("zombie_x" + i), PlayerPrefs.GetFloat("zombie_y" + i), PlayerPrefs.GetFloat("zombie_z" + i));
        //    //GameObject.Find(PlayerPrefs.GetString("Name_zombies" + i)).transform.rotation = Quaternion.Euler(zombies.transform.rotation.x -75, zombies.transform.rotation.y+180, zombies.transform.rotation.z);
            
        //    Zombie_dead = GameObject.Find(PlayerPrefs.GetString("Name_zombies" + i)).GetComponent<Animator>();

        //    Zombie_dead.SetBool("Dead_load", true);

        //    //zombies.SetActive(false);

        //}
    }
    //public void Load_met()
    //{
    //    Transform Cur_play_position = this.gameObject.transform;
    //    Vector3 Player_Position = new Vector3(PlayerPrefs.GetFloat("PosX"), PlayerPrefs.GetFloat("PosY"), PlayerPrefs.GetFloat("PosZ"));
    //    bulletsScipt.BulletsInClip = PlayerPrefs.GetInt("BulletsInClip");
    //    bulletsScipt.BulletsInClip = PlayerPrefs.GetInt("BulletsInClip");
    //    Cur_play_position.position = Player_Position;
    //    save.num = PlayerPrefs.GetInt("Num");
    //    save.index = PlayerPrefs.GetInt("Index");
    //    for (int i = 0; i == save.num; i++)
    //    {
    //        GameObject zombies = GameObject.Find(PlayerPrefs.GetString("Name_zombies" + i));
    //        zombies.SetActive(false);

    //    }
    //    // GameObject.Find("Zombie").SetActive(false);
    //}
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {

            //Load_met();



        }
        if (Input.GetKeyDown(KeyCode.B))
        {

            Delet();



        }

    }
    void Delet()
    {
        Debug.Log("Delete");
        for (int i = 0; i < 100; i++)
        {

            PlayerPrefs.DeleteKey("Name_zombies" + i);
            PlayerPrefs.DeleteKey("zombie_x" + i);
            PlayerPrefs.DeleteKey("zombie_y" + i);
            PlayerPrefs.DeleteKey("zombie_z" + i);

        }
        save.num = 0;
        save.index = 0;
    }
}
