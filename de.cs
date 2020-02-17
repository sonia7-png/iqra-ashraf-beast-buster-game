using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class de : MonoBehaviour {

	 public int EnemyHealth = 20;
    public GameObject theEnemy;
    public int statuscheck;
   public AudioSource Death;
   public GameObject heart;
    void DamageZombie(int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }

    // Update is called once per frame
    void Update () {
		if(EnemyHealth<=0 && statuscheck == 0)
        {
            this.GetComponent<zom>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;
            statuscheck = 2;
            theEnemy.GetComponent<Animation>().Stop("w");
            theEnemy.GetComponent<Animation>().Play("d");   
           Death.Play();
           heart.SetActive(true);
         
            
        }
	}
}
