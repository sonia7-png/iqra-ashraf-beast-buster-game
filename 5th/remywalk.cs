using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class remywalk : MonoBehaviour {

    public GameObject destination;
    public GameObject remy;
    public float Speed = 0.01f;
    public bool Trigger;

    void Update()
    {
        transform.LookAt(destination.transform);
        if (Trigger == false)
        {
            Speed = 0.01f;
            remy.GetComponent<Animation>().Play("remyWalk");
            transform.position = Vector3.MoveTowards(transform.position, destination.transform.position, Speed);
        }

    }
    
}
