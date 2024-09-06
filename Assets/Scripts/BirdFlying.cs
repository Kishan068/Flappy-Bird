using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BirdFlying : MonoBehaviour
{
    public GameObject gameover;
    public Text Score_title, Coin_title;
    Rigidbody2D r;
    Animator a;
    float speed = 3f;
    int Score = 0, Coin = 0, m = 0;
    bool hit = false;
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody2D>();
        a = GetComponent<Animator>();
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (m == 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Time.timeScale = 1;
                m++;
            }
        }
        if (hit == false)
        {
            r.velocity = new Vector2(5f, r.velocity.y);
            if (Input.GetMouseButtonDown(0))
            {
                r.velocity = new Vector2(r.velocity.x, speed);
            }
            Score = PlayerPrefs.GetInt("Score", 0);
            Coin = PlayerPrefs.GetInt("Coin", 0);
            Score_title.text = Score.ToString();
            Coin_title.text = Coin.ToString();
        }
    }
    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "PipePoint")
        {
            Destroy(c.gameObject);
            Score++;
            PlayerPrefs.SetInt("Score", Score);
        }
        if (c.gameObject.tag == "Pipe")
        {
            hit = true;
            r.velocity = new Vector2(0f, r.velocity.y);
            a.SetBool("isHit", true);
            gameover.SetActive(true);
            r.gravityScale = 0;
        }
        if (c.gameObject.tag == "Coin")
        {
            Destroy(c.gameObject);
            Coin++;
            PlayerPrefs.SetInt("Coin", Coin);
        }
    }
}
