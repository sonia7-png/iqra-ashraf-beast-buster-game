using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    public AudioSource GunFire;
    public bool isFiring = false;
    public GameObject theGun;

	void Update () {
      if (Input.GetButtonDown("Fire3"))
        {
            if (isFiring == false)
            {
                StartCoroutine(FiringPistol());
            }
        }
    }
    IEnumerator FiringPistol()
    {     
        isFiring = true;
        theGun.GetComponent<Animation>().Play("pisAnim");
        GunFire.Play();
        yield return new WaitForSeconds(0.5f);
        isFiring = false;
    }
	}
