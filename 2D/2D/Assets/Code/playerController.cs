using NUnit.Framework;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SocialPlatforms.Impl;

public class playerControler : MonoBehaviour
{


    public float speed;

    private Rigidbody2D rb;

    private int score = 0;

    private bool jump = false;

    public TextMeshProUGUI score_text;

    public List<GameObject> Lives = new List<GameObject>();

    // Start is called once before the first execution of Update after the MonoBehaviour is createdvoid Start()
    private void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per framevoid FixedUpdate()
    void FixedUpdate()
    {
        if (Keyboard.current.aKey.isPressed)
        {

            rb.AddForce(new Vector2(-speed, 0));

            //transform.position = new Vector3(-speed+transform.position.x, transform.position.y, 0); }

        }

        if (Keyboard.current.dKey.isPressed)
        {
                rb.AddForce(new Vector2(speed, 0));

                //transform.position = new Vector3(speed+transform.position.x, transform.position.y,0);        }
        }

        if (Keyboard.current.wKey.isPressed && jump)
        {

                    rb.AddForce(new Vector2(0, speed * 20));

                    //transform.position = new Vector3(speed+transform.position.y, transform.position.x, 0);        }
        }

        if (Keyboard.current.sKey.isPressed)
        {
                        rb.AddForce(new Vector2(0, -speed));

                        //transform.position = new Vector3(-speed+transform.position.y, transform.position.x, 0);        }

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)

    {

        if (collision.gameObject.CompareTag("pickup"))

        {

            score = score + 1;

            Debug.Log("score: " + score.ToString());

            score_text.text = $"Score je: {score}";

            collision.gameObject.SetActive(false);

        }

        if (collision.gameObject.CompareTag("pickup1"))

        {

            score = score + 2;

            Debug.Log("score: " + score.ToString());

            score_text.text = $"Score je: {score}";

            collision.gameObject.SetActive(false);

        }


    }


    private void OnCollisionExit2D(Collision2D collision)

    {

        if (collision.gameObject.CompareTag("ground"))

        {

            jump = false;

        }

    }


    private void OnCollisionStay2D(Collision2D collision)

    {

        if (collision.gameObject.CompareTag("ground"))

        {

            jump = true;

        }

    }
}


    /*private void OnCollisionEnter2D(Collision2D collision)

    {

        if (collision.gameObject.CompareTag("enemy"))

        {

            Lives[Lives.Count - 1].SetActive(false);

            Lives.RemoveAt(Lives.Count - 1);

        }

    }
    */

   