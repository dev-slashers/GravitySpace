﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FooterController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if(collider2D.gameObject.tag == "Player") UiManagerLevel1Controller.instance.GameOver(); 
    }
}
