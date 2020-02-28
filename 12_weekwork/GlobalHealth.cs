using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalHealth : MonoBehaviour {
    public static int currentHealth = 500;
    public int internalHealth;


	// Update is called once per frame
	void Update () {
        internalHealth = currentHealth;
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene(4);
        }
        if (ScringSystem.theScore==15)
        {
           SceneManager.LoadScene(2);
       }
	}
}
