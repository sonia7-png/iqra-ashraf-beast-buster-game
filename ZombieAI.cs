
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAi : MonoBehaviour {

    public GameObject human;
    public GameObject theEnemy;
    public GameObject z;
    public float EnemySpeed = 0.05f;
    public bool attackTrigger = false;
    public bool isAttacking = false;

    void Update()
    {
        transform.LookAt(human.transform);
        if (attackTrigger == false)
        {
            EnemySpeed = 0.05f;
            theEnemy.GetComponent<Animation>().Play("Walking (1)");
            transform.position = Vector3.MoveTowards(transform.position, human.transform.position, EnemySpeed);
        }
        if (attackTrigger == true && isAttacking == false)
        {
            EnemySpeed = 0;
            theEnemy.GetComponent<Animation>().Play("JillAttack");
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
        yield return new WaitForSeconds(0.1f);
        z.SetActive(true);
        human.SetActive(false);
        z.GetComponent<Animation>().Play("walk");
        yield return new WaitForSeconds(5f);
        theEnemy.SetActive(false);
        isAttacking = false;
    }
}
