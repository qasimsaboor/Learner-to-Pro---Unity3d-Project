using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveleveldata : MonoBehaviour
{


    public string stringname;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt(stringname, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
