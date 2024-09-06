using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGGenerator : MonoBehaviour
{
    public GameObject BGPrefabe, genPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < genPoint.transform.position.x)
        {
            transform.position = new Vector2(transform.position.x + 18f, transform.position.y);
            Instantiate(BGPrefabe, transform.position, Quaternion.identity);
        }
    }
}
