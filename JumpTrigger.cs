using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTrigger : MonoBehaviour {
    public AudioSource jumpmusic;
    public GameObject TheZombie;
    public GameObject Zombieobj;
    public GameObject AttkZombie;
    public GameObject TheZombie2;
    public GameObject Zombiewal;
    public GameObject TheZmbies3;
    public GameObject ZombieObj;


	// Use this for initialization
	void OnTriggerEnter() {
        GetComponent<BoxCollider>().enabled = false;
        jumpmusic.Play();
        TheZombie.SetActive(true);
        Zombieobj.SetActive(true);
        AttkZombie.SetActive(true);
        TheZombie2.SetActive(true);
        Zombiewal.SetActive(true);
        TheZmbies3.SetActive(true);
        ZombieObj.SetActive(true);

	}
	
	
}
