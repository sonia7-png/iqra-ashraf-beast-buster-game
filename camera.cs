using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {
 public GameObject camOne;
    public GameObject camTwo;
    public int CamNum;
    public bool CamOn = false;
    public AudioSource horror;
       public AudioSource Backhorror;
	// Use this for initialization
	void Start () {
        CamNum = 1;
        StartCoroutine(camSwitch());
	}
	
	IEnumerator camSwitch()
    {
        yield return new WaitForSeconds(5);
        horror.Play();
        yield return new WaitForSeconds(2);
        Backhorror.Play();
        camTwo.SetActive(true);
        camOne.SetActive(false);
        CamOn = true;
        CamNum = 2;
    } 
}
