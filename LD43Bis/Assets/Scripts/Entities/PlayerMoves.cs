using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoves : MonoBehaviour {
       
    private float moveSpeed;

    private Rigidbody2D rb2d;
    
    private Vector2 newPos;
    
    // Use this for initialization
    void Start () {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        newPos = gameObject.GetComponent<Transform>().position;
    }
	
	// Update is called once per frame
	void FixedUpdate () {

        if (gameObject.GetComponentInChildren<Character>() != null)
        {
            moveSpeed = gameObject.GetComponentInChildren<Character>().GetMoveSpeed();
        }
        else
        {
            moveSpeed = 0;
        }
       

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
