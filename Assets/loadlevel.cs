using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadlevel : MonoBehaviour
{
    public string level;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void loadlevels() 
    {
        SceneManager.LoadScene(level);
    }
    public void Restart()
    {
        SceneManager.LoadScene("caravoid");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
