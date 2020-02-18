using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;
using Random = UnityEngine.Random;

public class Aopening : MonoBehaviour {
    public GameObject ThePlayer;

    public GameObject TextBox;

    void Start()
    {
        ThePlayer.GetComponent<FirstPersonController>().enabled = false;
        StartCoroutine(ScenePlayer());
    }

    IEnumerator ScenePlayer()
    {
        yield return new WaitForSeconds(1.5f);

        TextBox.GetComponent<Text>().text = "U need to pickup 20 powers and then goes to next Level";
        yield return new WaitForSeconds(2);
        TextBox.GetComponent<Text>().text = "";
        ThePlayer.GetComponent<FirstPersonController>().enabled = true;

    }
	
}
