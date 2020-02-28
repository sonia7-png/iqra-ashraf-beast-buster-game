using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDeath : MonoBehaviour {

    public int EnemyHealth = 20;
    public GameObject theEnemy;
    public int statuscheck;
    public AudioSource Death;
  
    void DamageZombie(int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }

    // Update is called once per frame
    void Update () {
		if(EnemyHealth<=0 && statuscheck == 0)
        {
            this.GetComponent<ZAI>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;
            statuscheck = 2;
            theEnemy.GetComponent<Animation>().Stop("Walking");
            theEnemy.GetComponent<Animation>().Play("Rifle Death");
           Death.Play();
        }
	}
}
