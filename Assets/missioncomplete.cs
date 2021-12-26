using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
namespace UnityStandardAssets.ImageEffects
{
    public class missioncomplete : MonoBehaviour
    {
        public GameObject completeui;
        public GameObject uitoremove;
        GameObject camera;

        // Start is called before the first frame update
        void Start()
        {
            camera= GameObject.FindWithTag("MainCamera");
        }

        // Update is called once per frame
        void Update()
        {

        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "destination") {
                completeui.SetActive(true);
                camera.GetComponent<BlurOptimized>().enabled = true;
                uitoremove.SetActive(false);
                this.gameObject.GetComponent<CarUserControl>().enabled = false;
                this.gameObject.GetComponent<speedcheck>().enabled = false;
            }
           
        }
    }
}