using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootgun : MonoBehaviour {
  
    public GameObject theGun;
    public AudioSource GunFire;  
    public bool isFiring = false;
    public float TargetDistance;
    public int DamageAmount = 5;
        public GameObject MuzzleFlash;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (isFiring == false)
            {
                StartCoroutine(FiringPistol());
            }
        }
    }
    IEnumerator FiringPistol()
    {
        RaycastHit Shot;
        isFiring = true;
        if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out Shot)){
            TargetDistance = Shot.distance;
            Shot.transform.SendMessage("DamageZombie", DamageAmount, SendMessageOptions.DontRequireReceiver);
        }
        MuzzleFlash.SetActive(true);
        GunFire.Play();
        yield return new WaitForSeconds(.1f);
        MuzzleFlash.SetActive(false);
        isFiring = false;
    }
}
