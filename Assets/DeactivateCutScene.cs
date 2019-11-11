using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateCutScene : MonoBehaviour
{
    public GameObject CutScene;
    // Start is called before the first frame update
    void Start()
    {
        CutScene.SetActive(false);
    }

    // Update is called once per frame
   
}
