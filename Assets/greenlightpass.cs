﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenlightpass : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject failpanel;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "trafficlight") {
            failpanel.SetActive(true);
        }
    }
}
