using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class park : MonoBehaviour
{

    public bool left;
    public bool right;
    public bool front;
    public bool back;
    public Text val;
      int a = 5;
    float timeLeft = 5f;
    public GameObject Timersound;
    public GameObject Sucesssound;
    public GameObject Sucessspanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    private void Update()
    {
        if (left == true && right == true && front == true && back == true)
        {
            val.enabled = true;
            Timersound.SetActive(true);

            timeLeft -= Time.deltaTime;
            a= (int) timeLeft;
            

            val.text = a.ToString();
            if (timeLeft < 1)
            {
                Sucesssound.SetActive(true);
                Timersound.SetActive(false);
            }

            if (timeLeft  <=0)
            {
                val.enabled = false;
                Sucessspanel.SetActive(true);
            }





        }
        else {

            timeLeft = 5;
            a = 5;
            Timersound.SetActive(false);
            val.enabled = false;

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "left") {
            left = true;
        }
        if (other.tag == "right") {
            right = true;
        }
        if (other.tag == "front") {

            front = true;
        }
        if (other.tag == "back") {
            back = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "left")
        {
            left = false;
        }
        if (other.tag == "right")
        {
            right = false;
        }
        if (other.tag == "front")
        {

            front = false;
        }
        if (other.tag == "back")
        {
            back = false;
        }
    }

}
