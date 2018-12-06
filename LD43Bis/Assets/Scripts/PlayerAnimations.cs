using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour {

    private Animator characterAnimator;

    private Vector2 oldPos;
    private Vector2 newPos;

	// Use this for initialization
	void Start () {

        oldPos = gameObject.GetComponent<Transform>().position;

        if (gameObject.GetComponentInChildren<Animator>() != null)
        {
            characterAnimator = gameObject.GetComponentInChildren<Animator>();
        }       

	}
	
	// Update is called once per frame
	void FixedUpdate () {

        newPos = gameObject.GetComponent<Transform>().position;

        
        if (gameObject.GetComponentInChildren<Animator>() != null)
        {
            characterAnimator = gameObject.GetComponentInChildren<Animator>();

            if (!Input.GetKey("z") && !Input.GetKey("q") && !Input.GetKey("s") && !Input.GetKey("d")
                && characterAnimator.GetBool("walkUp") == true)
            {
                Reset();
                characterAnimator.SetBool("idleUp", true);
            }

            if (!Input.GetKey("z") && !Input.GetKey("q") && !Input.GetKey("s") && !Input.GetKey("d") 
                && characterAnimator.GetBool("walkLeft") == true)
            {
                Reset();
                characterAnimator.SetBool("idleLeft", true);
            }

            if (!Input.GetKey("z") && !Input.GetKey("q") && !Input.GetKey("s") && !Input.GetKey("d") 
                && characterAnimator.GetBool("walkDown") == true)
            {
                Reset();
                characterAnimator.SetBool("idleDown", true);
            }

            if (!Input.GetKey("z") && !Input.GetKey("q") && !Input.GetKey("s") && !Input.GetKey("d") 
                && characterAnimator.GetBool("walkRight") == true)
            {
                Reset();
                characterAnimator.SetBool("idleRight", true);
            }

            if (Input.GetKey("z"))
            {
                Reset();
                characterAnimator.SetBool("walkUp", true);
            }

            if (Input.GetKey("q"))
            {
                Reset();
                characterAnimator.SetBool("walkLeft", true);
            }

            if (Input.GetKey("s"))
            {
                Reset();
                characterAnimator.SetBool("walkDown", true);
            }

            if (Input.GetKey("d"))
            {
                Reset();
                characterAnimator.SetBool("walkRight", true);
            }
                        
        }
        else
        {
            characterAnimator = null;
        }

        oldPos = newPos;
        
    }

    private void Reset()
    {
        if (gameObject.GetComponentInChildren<Animator>() != null)
        {
            characterAnimator.SetBool("walkUp", false);
            characterAnimator.SetBool("walkLeft", false);
            characterAnimator.SetBool("walkDown", false);
            characterAnimator.SetBool("walkRight", false);
            characterAnimator.SetBool("idleUp", false);
            characterAnimator.SetBool("idleLeft", false);
            characterAnimator.SetBool("idleDown", false);
            characterAnimator.SetBool("idleRight", false);
        }

    }

}
