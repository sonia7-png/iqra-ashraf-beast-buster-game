using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAI : MonoBehaviour {

    public GameObject human;
    public GameObject theEnemy;
    public GameObject z;
    public float EnemySpeed = 0.02f;
    public bool attackTrigger = false;
    public bool isAttacking = false;

    void Update()
    {
        transform.LookAt(human.transform);
        if (attackTrigger == false)
        {
            EnemySpeed = 0.02f;
            theEnemy.GetComponent<Animation>().Play("Zombie Walk");
            transform.position = Vector3.MoveTowards(transform.position, human.transform.position, EnemySpeed);
        }
        if (attackTrigger == true && isAttacking == false)
        {
            EnemySpeed = 0;
            theEnemy.GetComponent<Animation>().Play("Zombie Punching");
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
        z.GetComponent<Animation>().Play("Walking");
        yield return new WaitForSeconds(5f);
        theEnemy.SetActive(false);
        isAttacking = false;
    }
}
