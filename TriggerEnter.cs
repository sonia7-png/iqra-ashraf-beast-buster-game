using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnter : MonoBehaviour {

    public AudioSource Music;
    public GameObject TheZombie1;
    public GameObject Zombieobj1;
    public GameObject AttkZombie2;
    public GameObject TheZombie3;
    public GameObject Zombiewalk1;
    public GameObject TheZmbies2;
    public GameObject ZombieObj2;


    // Use this for initialization
    void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
        Music.Play();
        TheZombie1.SetActive(true);
        Zombieobj1.SetActive(true);
        AttkZombie2.SetActive(true);
        TheZombie3.SetActive(true);
        Zombiewalk1.SetActive(true);
        TheZmbies2.SetActive(true);
        ZombieObj2.SetActive(true);

    }
}
