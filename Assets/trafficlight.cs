using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trafficlight : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject red;
    public GameObject yellow;
    public GameObject green;
    public GameObject passcollider;

    void Start()
    {
        StartCoroutine(ExampleCoroutine());
    }

    // Update is 
    IEnumerator ExampleCoroutine()
    {



        greenmethod();
        yield return new WaitForSeconds(5);

        yellowmethod();
        yield return new WaitForSeconds(2);
        redmethod();
        yield return new WaitForSeconds(5);
        yellowmethod();
        StartCoroutine(ExampleCoroutine());
    }

    void Update()
    {
       
    }
    public void redmethod() {
        red.SetActive(true);
        yellow.SetActive(false); green.SetActive(false);
        passcollider.GetComponent<Collider>().enabled = true;
    }
    public void greenmethod() { green.SetActive(true);
        yellow.SetActive(false);
        red.SetActive(false);
        passcollider.GetComponent<Collider>().enabled = false;
    }
    public void yellowmethod() { green.SetActive(false);
        yellow.SetActive(true);
        red.SetActive(false);
    }


}
