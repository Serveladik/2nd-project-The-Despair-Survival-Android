using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OnAwakeSettings : MonoBehaviour
{
    public Slider musicSlider;
    public Slider soundSlider;
    public Slider sensSlider;
    // Start is called before the first frame update
    void Start()
    {
        musicSlider.value = 2f; 
        soundSlider.value = 2f;
        sensSlider.value = 2f;
    }

    // Update is called once per frame
   
}
