using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyCombat : MonoBehaviour {

    private GameObject player;

    private Vector2 playerPos;

    private float distanceForAttack;

    private int attackDistance;

    private float distanceForDie;

    // Use this for initialization
    void Start () {
               
        attackDistance = gameObject.GetComponent<CharacterNonPlayable>().GetAttackDistance();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        player = GameObject.Find("Player");

        if (player.GetComponentInChildren<CharacterPlayable>() != null && gameObject.GetComponent<CharacterNonPlayable>().GetIsFightAllowed() == true)
        {           
            if ((player.GetComponentInChildren<CharacterPlayable>().gameObject.name == "Warrior" && gameObject.GetComponent<CharacterNonPlayable>().GetWeakVsWarrior() == false)
                || (player.GetComponentInChildren<CharacterPlayable>().gameObject.name == "Archer" && gameObject.GetComponent<CharacterNonPlayable>().GetWeakVsArcher() == false)
                || (player.GetComponentInChildren<CharacterPlayable>().gameObject.name == "Picklock" && gameObject.GetComponent<CharacterNonPlayable>().GetWeakVsPicklock() == false))
            {               
                playerPos = player.GetComponent<Transform>().position;

                distanceForAttack = Mathf.Abs((playerPos.x - gameObject.GetComponent<Transform>().position.x) * (playerPos.x - gameObject.GetComponent<Transform>().position.x) + (playerPos.y - gameObject.GetComponent<Transform>().position.y) * (playerPos.y - gameObject.GetComponent<Transform>().position.y));

                if (distanceForAttack <= attackDistance)
                {                   
                    player.GetComponent<PlayerCombat>().Die();
                }

            }

        }

    }

    void OnMouseDown()
    {        
        playerPos = player.GetComponent<Transform>().position;
        distanceForDie = Mathf.Abs((playerPos.x - gameObject.GetComponent<Transform>().position.x) * (playerPos.x - gameObject.GetComponent<Transform>().position.x) + (playerPos.y - gameObject.GetComponent<Transform>().position.y) * (playerPos.y - gameObject.GetComponent<Transform>().position.y));

        if (distanceForDie <= player.GetComponentInChildren<CharacterPlayable>().GetAttackDistance())
        {
            Die();
        }
    }

    private void Die()
    {
        if ((player.GetComponentInChildren<CharacterPlayable>().gameObject.name == "Warrior" && gameObject.GetComponent<CharacterNonPlayable>().GetWeakVsWarrior() == true)
                || (player.GetComponentInChildren<CharacterPlayable>().gameObject.name == "Archer" && gameObject.GetComponent<CharacterNonPlayable>().GetWeakVsArcher() == true)
                || (player.GetComponentInChildren<CharacterPlayable>().gameObject.name == "Picklock" && gameObject.GetComponent<CharacterNonPlayable>().GetWeakVsPicklock() == true))
        {
            Destroy(gameObject);
        }        
    }

}
