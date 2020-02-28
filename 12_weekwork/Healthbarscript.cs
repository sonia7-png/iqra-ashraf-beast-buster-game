using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Healthbarscript : MonoBehaviour {
    Image healthBar;
    float currentHealth = 2000f;
    public static float internalHealth;
	// Use this for initialization
	void Start () {
        healthBar = GetComponent<Image>();
        internalHealth = currentHealth;
	}
	
	// Update is called once per frame
	void Update () {
        healthBar.fillAmount = internalHealth / currentHealth;
	}
}
