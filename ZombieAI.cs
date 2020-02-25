using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieAI : MonoBehaviour {
    public GameObject thePlayer;
    public GameObject theEnemy;
    public float EnemySpeed = 0.05f;
    public bool attackTrigger = false;
    public bool isAttacking = false;
  
    public int hurtGen;
//Call every frame
void Update()
{
      transform.LookAt(thePlayer.transform);
        if (attackTrigger == false)
        {
            EnemySpeed = 0.05f;
            theEnemy.GetComponent<Animation>().Play("walk");
            transform.position = Vector3.MoveTowards(transform.position, thePlayer.transform.position, EnemySpeed);
        }
       if(attackTrigger==true && isAttacking == false)
        {
            EnemySpeed = 0;
            theEnemy.GetComponent<Animation>().Play("Attack");
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
       
       
     // theFlash.SetActive(true);
      yield return new WaitForSeconds(0.1f);
       // theFlash.SetActive(false);
      // yield return new WaitForSeconds(1.1f);
     GlobalHealth.currentHealth -= 5;
       // yield return new WaitForSeconds(0.9f);
        isAttacking = false;
    }
}
