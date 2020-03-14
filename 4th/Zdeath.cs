using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zdeath : MonoBehaviour {

	
    public int EnemyHealth = 20;
    public GameObject theEnemy;
    public int statuscheck;
    public AudioSource d;
    public ParticleSystem particleBurst;
    private bool played;
    void DamageZombie(int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyHealth <= 0 && statuscheck == 0)
        {
            this.GetComponent<ZombieAI>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;
            statuscheck = 2;
            theEnemy.GetComponent<Animation>().Stop("Zombie Walk");
            if (!played)
            {
                particleBurst.Play();
                played = true;
            }
            theEnemy.GetComponent<Animation>().Play("Death From The Front");
          
            d.Play();
        }
    }
}
