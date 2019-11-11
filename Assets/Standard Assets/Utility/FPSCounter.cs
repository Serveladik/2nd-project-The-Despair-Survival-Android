using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;



   
    public class FPSCounter : MonoBehaviour
    {
       
        private Text m_Text;


       private void Start()
        {
            m_Text = GetComponent<Text>();
            StartCoroutine("FPScounter");
        }
        IEnumerator FPScounter()
        {
           while(true)
           {
                float fps = 1/Time.deltaTime;
                m_Text.text = fps.ToString("#");
                yield return new WaitForSeconds(0.5f);   
           }
        }
    }

