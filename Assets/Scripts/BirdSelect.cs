using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BirdSelect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void birdSelect(int b)
    {
        PlayerPrefs.SetInt("BirdNo", b);
        SceneManager.LoadScene("Play");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
