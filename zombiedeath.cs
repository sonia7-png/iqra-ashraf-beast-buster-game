using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zom : MonoBehaviour {

 public GameObject thePlayer;
    public GameObject theEnemy;
    public float EnemySpeed = 0.01f;
    public bool attackTrigger = false;
    public bool isAttacking = false;
 

//Call every frame
void Update()
{
      transform.LookAt(thePlayer.transform);
        if (attackTrigger == false)
        {
            EnemySpeed = 0.01f;
            theEnemy.GetComponent<Animation>().Play("w");
            transform.position = Vector3.MoveTowards(transform.position, thePlayer.transform.position, EnemySpeed);
        }
       if(attackTrigger==true && isAttacking == false)
        {
            EnemySpeed = 0; 
            theEnemy.GetComponent<Animation>().Play("a");
            StartCoroutine(InflictDamage());

        }
}
 void OnTriggerEnter()
    {
        attackTrigger = true;   
    }
    void OnTriggerExit()
    {
        attackTrigger = false;
    }
     IEnumerator InflictDamage()
    {
		 
        isAttacking = true;
      yield return new WaitForSeconds(0.1f);
   
     GlobalHealth.currentHealth -= 10;
     Healthbarscript.internalHealth -= 10f;
        isAttacking = false;
    }
}
