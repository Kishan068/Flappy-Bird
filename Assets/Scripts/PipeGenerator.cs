using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    public GameObject pipePrefabe, genpos;
    float prepos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < genpos.transform.position.x)
        {
            float posX = Random.Range(13f, 22f);
            float posY = Random.Range(-2f, 3f);
            transform.position = new Vector2(transform.position.x + posX, posY);
            Instantiate(pipePrefabe, transform.position, Quaternion.identity);
        }
    }
}
