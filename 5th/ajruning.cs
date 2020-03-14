using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ajruning : MonoBehaviour {
    public GameObject destination;
    public GameObject aj;
    public float Speed = 0.01f;
    public bool Trigger;

    void Update()
    {
        transform.LookAt(destination.transform);
        if (Trigger == false)
        {
            Speed = 0.01f;
            aj.GetComponent<Animation>().Play("Running");
            transform.position = Vector3.MoveTowards(transform.position, destination.transform.position, Speed);
        }

    }
}
