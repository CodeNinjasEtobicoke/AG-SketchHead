﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //Platform gameobject
    [Header("Platform Object")]
    public GameObject platform;
    //Defaut position for platform
    float pos = 0;
    // Start is called before the first frame update
    void Start()
    {
        //Interger i equals 1000
        for (int i = 0; i < 1000; i++)
        {
            //Execute SpawnPlatforms
            SpawnPlatforms();
            
        }
    }
    //Spawn platforms function
     void SpawnPlatforms()
    {
        //spawn platforms randomly on the y axis every 2.5
       Instantiate(platform, new Vector3(Random.value * 10) - 5f, pos, 0.5f), Quaternion.identity);
        pos
    }

    // Update is called once per frame
    void Update()
    {

    }


}
