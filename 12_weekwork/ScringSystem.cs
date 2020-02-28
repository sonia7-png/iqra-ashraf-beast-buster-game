using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScringSystem : MonoBehaviour {
    public GameObject scoreText;
    public static  int theScore;
    

    void Update()
    {


        scoreText.GetComponent<Text>().text = "POWER: " + theScore;
       
    }
}
