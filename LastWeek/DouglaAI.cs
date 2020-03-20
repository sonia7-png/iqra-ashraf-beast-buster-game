using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DouglaAI : MonoBehaviour {


 public GameObject thePlayer;
    public GameObject theEnemy;
    public float EnemySpeed ;
    public bool attackTrigger = false;
    public bool isAttacking = false;
   

//Call every frame
void Update()
{
      transform.LookAt(thePlayer.transform);
        if (attackTrigger == false)
        {
            EnemySpeed = 0.05f;
            theEnemy.GetComponent<Animation>().Play("Wheelbarrow Walk");
            transform.position = Vector3.MoveTowards(transform.position, thePlayer.transform.position, EnemySpeed);
        }
       if(attackTrigger==true && isAttacking == false)
        {
            EnemySpeed = 0; 
            theEnemy.GetComponent<Animation>().Play("Boxing");
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

      globalhealth2.currentHealth -= 2;
      Healthbarscript.internalHealth -= 2f;
        isAttacking = false;
    }
}
