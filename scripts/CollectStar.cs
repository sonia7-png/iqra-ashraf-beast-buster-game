﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectStar : MonoBehaviour {
   
    public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
       ScringSystem.theScore += 1;
       
        Destroy(gameObject);
    }
}
