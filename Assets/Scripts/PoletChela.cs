using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PoletChela : MonoBehaviour
{

    public Rigidbody2D rb;
    public Vector2 moveVector;
    public Animator anim;

    public float speed ;

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetInteger("skin", PlayerPrefs.GetInt("skin"));
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveVector = moveInput.normalized * speed;
    }
    

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVector * Time.fixedDeltaTime);
    }

}