using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdNo : MonoBehaviour
{
    public GameObject[] Birds;
    int BirdN = 0;
    // Start is called before the first frame update
    void Start()
    {
        BirdN = PlayerPrefs.GetInt("BirdNo", 0);
        Birds[BirdN].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
