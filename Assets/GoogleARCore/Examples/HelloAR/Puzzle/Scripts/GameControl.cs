using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    [SerializeField]
    private Transform[] pictures;
    [SerializeField]
    private GameObject wintext;


    public static bool youwin;

    public void Start()
    {
        wintext.SetActive(false);
        youwin = false;
    }
    public void Update()
    {
     if(pictures[0].rotation.z == 0 &&
           pictures[1].rotation.z == 0 &&
           pictures[2].rotation.z == 0 &&
                pictures[3].rotation.z == 0)
        {
            youwin = true;
            wintext.SetActive(true);
        }   
    }
}
