using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour {
    
    private GameManager scr;

	// Use this for initialization
	void Start () {
        scr = GameObject.Find("GameManager").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Die()
    {
        string characterName = gameObject.GetComponentInChildren<CharacterPlayable>().gameObject.name;

        Destroy(gameObject.GetComponentInChildren<CharacterPlayable>().gameObject);

        if (characterName == "Warrior")
        {
            scr.SetIsWarriorAlive(false);
        }
        else if (characterName == "Archer")
        {
            scr.SetIsArcherAlive(false);
        }
        else if (characterName == "Picklock")
        {
            scr.SetIsPicklockAlive(false);
        }

        scr.ChangeCharacter();

    }

}
