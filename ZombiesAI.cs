using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiesAI : MonoBehaviour {


    public GameObject Player;
    public GameObject theEnemy;
    public float EnemySpeed = 0.09f;
    public bool attackTrigger = false;
    public bool isAttacking = false;

    void Update()
    {
        transform.LookAt(Player.transform);
        if (attackTrigger == false)
        {
            EnemySpeed = 0.02f;
            theEnemy.GetComponent<Animation>().Play("walk 1");
            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, EnemySpeed);
        }
        if (attackTrigger == true && isAttacking == false)
        {
            EnemySpeed = 0;
            theEnemy.GetComponent<Animation>().Play("attack");
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
        yield return new WaitForSeconds(2f);
        GlobalHealth.currentHealth -= 5;
        isAttacking = false;
    }
}
