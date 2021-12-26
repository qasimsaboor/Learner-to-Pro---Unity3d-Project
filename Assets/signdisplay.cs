using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class signdisplay : MonoBehaviour
{

    public GameObject signui;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            signui.SetActive(true);

            Debug.Log("Working");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player") {
            signui.SetActive(false);
            Destroy(this.gameObject);
            Debug.Log("Working");
        }
    }

}
