using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;
namespace UnityStandardAssets.ImageEffects
{
    public class speedcheck : MonoBehaviour
    {
        // Start is called before the first frame update


        public float Speed;
        public GameObject loseui;
        public int minspeed;
        public int maxspeed;
        public Text SPEEDTEXT;
        bool startfailprocess;
        GameObject camera;
        void Start()
        {
            camera = GameObject.FindWithTag("MainCamera");

        }

        // Update is called once per frame
        void Update()
        {
           
            Speed = GetComponent<Rigidbody>().velocity.magnitude * 3.6f;
             SPEEDTEXT.text = "" + ((int)Speed).ToString();

            if (Speed > minspeed)
            {
                startfailprocess = true;
            }
            if (startfailprocess == true)
            {
                if (Speed <= minspeed || Speed >= maxspeed)
                {
                    camera.GetComponent<BlurOptimized>().enabled = true;
                    loseui.SetActive(true);

                    this.gameObject.GetComponent<CarUserControl>().enabled = false;
                }
            }
        }
    }
}