using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideZombies : MonoBehaviour {

    
    public GameObject TheZombie1;
    public GameObject TheZombie2;
    public GameObject TheZombie3;
    public GameObject TheZombie4;

    // Use this for initialization
    void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
      
        TheZombie1.SetActive(true);
        TheZombie2.SetActive(true);
        TheZombie3.SetActive(true);
        TheZombie4.SetActive(true);
    }
}
