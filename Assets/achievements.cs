using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class achievements : MonoBehaviour
{

    public GameObject speedpic;

    public GameObject parkingpic;

    public GameObject awarenesslanepic;

    public GameObject trafficsignspic;

    public GameObject trafficlightpic;

    public GameObject avoidcarpic;
     public string abc;

    // Start is called before the first frame update
    void Start()
    {

       // PlayerPrefs.DeleteAll();
        int speed = PlayerPrefs.GetInt("speed", 0);

        int parking = PlayerPrefs.GetInt("parking", 0);

        int awarenesslane = PlayerPrefs.GetInt("awarenesslane", 0);
        int trafficsigns = PlayerPrefs.GetInt("trafficsigns", 0);
        int trafficlight = PlayerPrefs.GetInt("trafficlight", 0);
        int avoidcar = PlayerPrefs.GetInt("avoidcar", 0);

        Debug.Log(speed);

        if (speed == 1) {

            speedpic.SetActive(true);
        }
        if (parking == 1)
        {

            parkingpic.SetActive(true);
        }
        if (trafficsigns == 1)
        {

            trafficsignspic.SetActive(true);
        }
        if (awarenesslane == 1)
        {

            awarenesslanepic.SetActive(true);
        }
        if (avoidcar == 1)
        {

            avoidcarpic.SetActive(true);
        }
        if (trafficlight == 1)
        {

            trafficlightpic.SetActive(true);
        }







    }




    // Update is called once per frame
    void Update()
    {
        
    }

}