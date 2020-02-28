using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZAI : MonoBehaviour {

 public GameObject thePlayer;
    public GameObject theEnemy;
    public float EnemySpeed ;
    public bool attackTrigger = false;
    public bool isAttacking = false;
     public AudioSource help;

//Call every frame
void Update()
{
      transform.LookAt(thePlayer.transform);
        if (attackTrigger == false)
        {
            EnemySpeed = 0.01f;
            theEnemy.GetComponent<Animation>().Play("Walking");
            transform.position = Vector3.MoveTowards(transform.position, thePlayer.transform.position, EnemySpeed);
        }
       if(attackTrigger==true && isAttacking == false)
        {
            EnemySpeed = 0; 
            theEnemy.GetComponent<Animation>().Play("Zombie Attack");
            StartCoroutine(InflictDamage());

        }
}
 void OnTriggerEnter()
    {
        attackTrigger = true;   help.Play();   
    }
    void OnTriggerExit()
    {
        attackTrigger = false;
    }
     IEnumerator InflictDamage()
    {
		 
        isAttacking = true;
      yield return new WaitForSeconds(0.1f);

      globalhealth2.currentHealth -= 2;
      Healthbarscript.internalHealth -= 2f;
        isAttacking = false;
    }
}
