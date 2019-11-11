using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class save_script : MonoBehaviour
{

    public GameObject Cur_play_position;
    public BulletsScipt bulletsScipt;
    public GameObject Text_save;
    public Animator Save_anim;
    private GameObject bottle;
    public GameObject My_bootle;
    public GameObject pistol;
    public GameObject hand_1;
    public GameObject hand_2;
    private bool check = false;
    List<string> name_list = new List<string>() { };
    List<float> zombie_x = new List<float>() { };
    List<float> zombie_y = new List<float>() { };
    List<float> zombie_z = new List<float>() { };
    public int num = 0;
    public int index = 0;


    void Start()
    {
        bottle = GameObject.Find("bottle_for_save");

    }
    public void DeadZombies(string name, float Zombie_x, float Zombie_y,float Zombie_z)
    {
        name_list.Add(name);
        zombie_x.Add(Zombie_x);
        zombie_y.Add(Zombie_y);
        zombie_z.Add(Zombie_z);
        num++;
        //num++;

        for (int i = index; i < num; i++)
        {

            PlayerPrefs.SetString("Name_zombies" + i, name_list[0]);
            PlayerPrefs.SetFloat("zombie_x" + i, zombie_x[0]);
            PlayerPrefs.SetFloat("zombie_y" + i, zombie_y[0]);
            PlayerPrefs.SetFloat("zombie_z" + i, zombie_z[0]);
            name_list.RemoveAt(0);
            zombie_x.RemoveAt(0);
            zombie_y.RemoveAt(0);
            zombie_z.RemoveAt(0);
        }
        index++;


    }
    public void Save()
    {
        try
        {
            PlayerPrefs.DeleteKey("PosX");
            PlayerPrefs.DeleteKey("PosY");
            PlayerPrefs.DeleteKey("PosZ");
            PlayerPrefs.DeleteKey("BulletsInClip");
            PlayerPrefs.DeleteKey("BulletsLeft");
            PlayerPrefs.DeleteKey("Num");
            PlayerPrefs.DeleteKey("Index_");
        }
        catch
        {
            Debug.Log("You does't have Save");
        }

        PlayerPrefs.SetFloat("PosX", Cur_play_position.transform.position.x);
        PlayerPrefs.SetFloat("PosY", Cur_play_position.transform.position.y);
        PlayerPrefs.SetFloat("PosZ", Cur_play_position.transform.position.z);
        PlayerPrefs.SetInt("BulletsInClip", bulletsScipt.BulletsInClip);
        PlayerPrefs.SetInt("BulletsLeft", bulletsScipt.BulletsLeft);
        PlayerPrefs.SetInt("Num", num);
        PlayerPrefs.SetInt("Index_", index);

        StartCoroutine(AnimatorSetFire());


        Debug.Log("Save");
    }
    public void OnTriggerStay(Collider box)
    {

        if (box.gameObject.tag == "Main_Player")
        {
            Text_save.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                Save();
            }
        }
    }
    public void OnTriggerExit(Collider box)
    {

        if (box.gameObject.tag == "Main_Player")
        {
            Text_save.SetActive(false);
        }

    }
    public IEnumerator AnimatorSetFire()
    {

        if (pistol.activeSelf == true)
        {
            check = true;
            pistol.SetActive(false);
            hand_1.SetActive(true);
            hand_2.SetActive(true);
        }
        Destroy(transform.GetChild(0).gameObject);
        My_bootle.SetActive(true);
        Save_anim.SetBool("Save", true);
        yield return new WaitForSeconds((float)2.5);

        Save_anim.SetBool("Save", false);
        My_bootle.SetActive(false);
        if (check == true)
        {

            hand_1.SetActive(false);
            hand_2.SetActive(false);

            pistol.SetActive(true);
            check = false;
        }
    }

}

