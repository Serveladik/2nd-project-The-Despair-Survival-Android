using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverEffectScipt : MonoBehaviour
{
    public GameOverBool gameOverScript;
    public Animator GameOverAnim;
    public GameObject player;
    public GameObject ui;
    public AudioSource audio;
    public AudioClip[] clip;
    // Start is called before the first frame update
    public LavaDamageScript lavaBool;
void Start()
{

}
    // Update is called once per frame
    void Update()
    {
        if(this.gameOverScript.GameOver==true)
        {
            
            GameOverAnim.SetBool("GameOver",true);
            player.SetActive(false); 
            ui.SetActive(false);
            if(lavaBool.dead==true)
            {
                this.audio.clip = clip[Random.Range(0, clip.Length)];
                this.audio.PlayOneShot(audio.clip);
                lavaBool.dead=false; 
                StartCoroutine("RestartGame");
            }
        }
    }
    public IEnumerator RestartGame()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("MenuScene");
    }
}
