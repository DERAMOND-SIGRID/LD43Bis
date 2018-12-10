using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyMoves : MonoBehaviour {

    private float moveSpeed;

    private Rigidbody2D rb2d;

    private Vector2 newPos;
    private Vector2 playerPos;
       
    private float distance;

    private float x;
    private float y;

    private int attackDistance;

    private GameObject player;

    // Use this for initialization
    void Start () {

        moveSpeed = gameObject.GetComponent<Character>().GetMoveSpeed();
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        newPos = gameObject.GetComponent<Transform>().position;
        attackDistance = gameObject.GetComponent<Character>().GetAttackDistance();
        player = GameObject.Find("Player");
    }
	
	// Update is called once per frame
	void FixedUpdate() {

        if (player.GetComponentInChildren<CharacterPlayable>() != null && gameObject.GetComponent<CharacterNonPlayable>().GetIsFightAllowed() == true)
        {
            if ((player.GetComponentInChildren<CharacterPlayable>().gameObject.name == "Warrior" && gameObject.GetComponent<CharacterNonPlayable>().GetWeakVsWarrior() == false)
                || (player.GetComponentInChildren<CharacterPlayable>().gameObject.name == "Archer" && gameObject.GetComponent<CharacterNonPlayable>().GetWeakVsArcher() == false)
                || (player.GetComponentInChildren<CharacterPlayable>().gameObject.name == "Picklock" && gameObject.GetComponent<CharacterNonPlayable>().GetWeakVsPicklock() == false))
            {
                playerPos = player.GetComponent<Transform>().position;

                distance = Mathf.Abs((playerPos.x - gameObject.GetComponent<Transform>().position.x) * (playerPos.x - gameObject.GetComponent<Transform>().position.x) + (playerPos.y - gameObject.GetComponent<Transform>().position.y) * (playerPos.y - gameObject.GetComponent<Transform>().position.y));

                if (distance != 0)
                {
                    x = playerPos.x - ((attackDistance / distance) * (playerPos.x - rb2d.position.x));
                }
                else
                {
                    x = 0;
                }

                if (distance != 0)
                {
                    y = playerPos.y - ((attackDistance / distance) * (playerPos.y - rb2d.position.y));
                }
                else
                {
                    y = 0;
                }

                newPos = Vector2.MoveTowards(rb2d.position, new Vector3(x, y, 0), (1 / moveSpeed) * Time.deltaTime);
            }

        }
        
        rb2d.MovePosition(newPos);

    }
}
