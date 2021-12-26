using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avoider : MonoBehaviour
{

    public GameObject loseui;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            loseui.SetActive(true);
        }
    }
}
