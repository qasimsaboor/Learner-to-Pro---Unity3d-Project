using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class loadscene : MonoBehaviour
{

    public string abc;
    public void loading() {

        SceneManager.LoadScene(abc);
    }
}
