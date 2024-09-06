using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CameraControl : MonoBehaviour
{
    public GameObject[] Birds;
    public GameObject gameover;
    Vector2 offset;
    Animator a;
    int Score = 0, Coin = 0, BirdN = 0;
    // Start is called before the first frame update
    void Start()
    {
        BirdN = PlayerPrefs.GetInt("BirdNo", 0);
        offset = transform.position - Birds[BirdN].transform.position;
        a = Birds[BirdN].GetComponent<Animator>();
    }
    public void pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
    public void reset()
    {
        a.SetBool("isHit", false);
        gameover.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene("Play");
        Score = 0;
        PlayerPrefs.SetInt("Score", Score);
        Coin = 0;
        PlayerPrefs.SetInt("Coin", Coin);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Birds[BirdN].transform.position.x + offset.x, transform.position.y, transform.position.z);
    }
}
