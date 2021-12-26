using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {
    public Image  bar;
    public GameObject levelfailpanel;
    public GameObject Timer;
    
    public GameObject player;
    public float current=10f;
    public float max = 10f;
    public float burnrate = 1f;
	 
	
	void Update () {
        float hash = current / max;
        current = current-burnrate * Time.deltaTime;

        

        if (hash < 0)
        {
            levelfailpanel.SetActive(true);
            Timer.SetActive(false);
    
            Destroy(player);
        }

        seth(hash);
	}

void seth(float myh)
    {

        bar.fillAmount = myh;
    }
}

