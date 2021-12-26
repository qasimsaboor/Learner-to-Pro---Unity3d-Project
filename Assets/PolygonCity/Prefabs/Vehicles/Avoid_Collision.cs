using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avoid_Collision : MonoBehaviour
{
    public GameObject Game_over;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "car") 
        {
            Game_over.SetActive(true);
        }
       
    }
}
