using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvment : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float speed = 10f;
    [SerializeField]
    private float flapForce = 70f;
    bool isDead;
    void OnCollisionEnter2D(Collision2D col)
    {
        isDead = true;
        rb2d.velocity = Vector2.zero;
    }
    void Start()
    {

        rb2d = GetComponent<Rigidbody2D>();

        rb2d.velocity = Vector2.right * speed * Time.deltaTime;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isDead)
        {

            rb2d.velocity = Vector2.right * speed * Time.deltaTime;

            rb2d.AddForce(Vector2.up * flapForce);
        }




    }
    void OnColisionEnter2D(Collision2D col)
    {
        //DO NOT COPY THIS CODE, Edit the existing one

        isDead = true;
        rb2d.velocity = Vector2.zero;

        //Change the isDead parameter of the Animator to start the Dead animation
        GetComponent<Animator>().SetBool("isDead", true);
        //GetComponent<Animator>() is a reference to the Anim
    }
}