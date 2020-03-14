using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.AudioSource.clip;
[RequireComponent(typeof(Rigidbody))]
public class winingsound : MonoBehaviour {
    public AudioClip winsound;
    public GameObject particle;
    private Rigidbody rb;
    private AudioSource _audiosource;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        _audiosource = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "point")
        {
            Destroy(col.gameObject);
            Instantiate(particle, col.transform.position, col.transform.rotation);
            _audiosource.clip = winsound;
            _audiosource.Play();

        }
    }
}

