using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatAuthorization : MonoBehaviour
{

    [SerializeField]
    private List<GameObject> ennemiesInRoom;

    // Use this for initialization
    void Start()
    {

        foreach (GameObject ennemy in ennemiesInRoom)
        {
            if (ennemy != null)
            {
                ennemy.GetComponent<CharacterNonPlayable>().SetIsFightAllowed(false);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player") {
            Invoke("AllowedFight", 1);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            foreach (GameObject ennemy in ennemiesInRoom)
            {
                if (ennemy != null)
                {
                    ennemy.GetComponent<CharacterNonPlayable>().SetIsFightAllowed(false);
                }
            }
        }
    }

    private void AllowedFight()
    {
        foreach (GameObject ennemy in ennemiesInRoom)
        {
            if (ennemy != null)
            {
                ennemy.GetComponent<CharacterNonPlayable>().SetIsFightAllowed(true);
            }
        }
    }

}
