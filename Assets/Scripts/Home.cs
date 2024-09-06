using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void playbtn()
    {
        SceneManager.LoadScene("Play");
    }
    public void optionbtn()
    {
        SceneManager.LoadScene("Select");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
