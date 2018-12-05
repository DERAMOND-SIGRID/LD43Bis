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
	void Update () {

        newPos = gameObject.GetComponent<Transform>().position;


        if (gameObject.GetComponentInChildren<Animator>() != null)
        {
            characterAnimator = gameObject.GetComponentInChildren<Animator>();

            if (oldPos.y < newPos.y)
            {
                Reset();
                characterAnimator.SetBool("walkUp", true);
            }

            if (oldPos.x > newPos.x)
            {
                Reset();
                characterAnimator.SetBool("walkLeft", true);
            }

            if (oldPos.y > newPos.y)
            {
                Reset();
                characterAnimator.SetBool("walkDown", true);
            }

            if (oldPos.x < newPos.x)
            {
                Reset();
                characterAnimator.SetBool("walkRight", true);
            }

            if (oldPos == newPos && characterAnimator.GetBool("walkUp") == true)
            {
                Reset();
                characterAnimator.SetBool("idleUp", true);
            }

            if (oldPos == newPos && characterAnimator.GetBool("walkLeft") == true)
            {
                Reset();
                characterAnimator.SetBool("idleLeft", true);
            }

            if (oldPos == newPos && characterAnimator.GetBool("walkDown") == true)
            {
                Reset();
                characterAnimator.SetBool("idleDown", true);
            }

            if (oldPos == newPos && characterAnimator.GetBool("walkRight") == true)
            {
                Reset();
                characterAnimator.SetBool("idleRight", true);
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
