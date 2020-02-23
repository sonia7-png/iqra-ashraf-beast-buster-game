using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour {

    public GameObject Text;
    public GameObject Text1;
    public GameObject antivirus;
    public AudioSource winsound;
    public GameObject particle;
    public GameObject particle2;
    public GameObject particless;
    public GameObject particlethr;
    public GameObject particlefo;
    public GameObject particlefif;
    public GameObject particlesix;
    public GameObject particlesev;
    public GameObject Zombies;
    void OnTriggerEnter()
    {
        StartCoroutine(wait());

    }
    void Update()
    {
        if (Input.GetButtonDown("Action"))
        {
            antivirus.SetActive(false); Text1.SetActive(true);
            winsound.Play();
            particle.SetActive(true);
            particle2.SetActive(true);
            particless.SetActive(true);
            particlethr.SetActive(true);
            particlefo.SetActive(true);
            particlefif.SetActive(true);
            particlesix.SetActive(true);
            particlesev.SetActive(true);
            Zombies.SetActive(false);

        }
    }
    IEnumerator wait()
    {
        Text.SetActive(true);
        yield return new WaitForSeconds(1f);
        Text.SetActive(false);
        
    }
}
