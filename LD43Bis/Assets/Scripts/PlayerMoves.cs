﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoves : MonoBehaviour {

    [SerializeField]
    private float moveSpeed;

    private Rigidbody2D rb2d;
    
    private Vector2 newPos;
    
    // Use this for initialization
    void Start () {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {

        if (moveSpeed != 0) {

            if (Input.GetKey("z"))
            {
                newPos = Vector2.MoveTowards(rb2d.position, rb2d.position + Vector2.up, (1 / moveSpeed) * Time.deltaTime);                
            }

            if (Input.GetKey("q"))
            {
                newPos = Vector2.MoveTowards(rb2d.position, rb2d.position + Vector2.left, (1 / moveSpeed) * Time.deltaTime);
            }

            if (Input.GetKey("s"))
            {
                newPos = Vector2.MoveTowards(rb2d.position, rb2d.position + Vector2.down, (1 / moveSpeed) * Time.deltaTime);
            }

            if (Input.GetKey("d"))
            {
                newPos = Vector2.MoveTowards(rb2d.position, rb2d.position + Vector2.right, (1 / moveSpeed) * Time.deltaTime);
            }

            rb2d.MovePosition(newPos);

        }

	}

}