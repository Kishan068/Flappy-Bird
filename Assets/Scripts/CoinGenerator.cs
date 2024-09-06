using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{
    public GameObject coinPrefabe, genpos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < genpos.transform.position.x)
        {
            float posX = Random.Range(9f, 20f);
            float posY = Random.Range(-1.5f, 2.5f);
            transform.position = new Vector2(transform.position.x + posX, posY);
            Instantiate(coinPrefabe, transform.position, Quaternion.identity);
        }
    }
}
