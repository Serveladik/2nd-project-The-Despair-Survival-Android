using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ZombieLoopedSoundsScript : MonoBehaviour
{
    public AudioSource audioLooped;
    public Slider soundSlider;
    // Start is called before the first frame update
    void Start()
    {
        
        audioLooped=GetComponent<AudioSource>();
        audioLooped.volume = soundSlider.value;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        audioLooped.volume = soundSlider.value;
    }
}
