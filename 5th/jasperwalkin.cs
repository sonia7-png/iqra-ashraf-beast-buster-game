using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jasperwalkin : MonoBehaviour {
    public GameObject destination;
    public GameObject jasper;
    public float Speed = 0.05f;
    public bool Trigger;
    void Update()
    {
        transform.LookAt(destination.transform);
        if (Trigger == false)
        {
            Speed = 0.05f;
            jasper.GetComponent<Animation>().Play("jasperwalk");
            transform.position = Vector3.MoveTowards(transform.position, destination.transform.position, Speed);
        }

    }
}
