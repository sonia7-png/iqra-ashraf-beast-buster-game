using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour {
 public int EnemyHealth = 20;
    public GameObject theEnemy;
    public int statuscheck;
    public AudioSource Jumpscare;
    public AudioSource Amb;

    void DamageZombie(int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }

    // Update is called once per frame
    void Update () {
		if(EnemyHealth<=0 && statuscheck == 0)
        {
            this.GetComponent<zombieAI>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;
            statuscheck = 2;
            theEnemy.GetComponent<Animation>().Stop("walk");
            theEnemy.GetComponent<Animation>().Play("death");
            Jumpscare.Stop();
            Amb.Play();
        }
	}
}
