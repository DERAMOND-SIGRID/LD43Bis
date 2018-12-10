using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSelectCharacter : MonoBehaviour {

    [SerializeField]
    private string characterName;

    [SerializeField]
    private GameObject buttonValid;

	// Use this for initialization
	void Start () {

        GameManager gm = GameObject.Find("GameManager").GetComponent<GameManager>();

        if (characterName == "Warrior")
        {            
            if (gm.GetIsWarriorAlive() == false)
            {
                gameObject.GetComponent<Button>().interactable = false;
            }
        }
        else if (characterName == "Archer")
        {
            if (gm.GetIsArcherAlive() == false)
            {
                gameObject.GetComponent<Button>().interactable = false;
            }
        }
        else if (characterName == "Picklock")
        {
            if (gm.GetIsPicklockAlive() == false)
            {
                gameObject.GetComponent<Button>().interactable = false;
            }
        }

    }
	
	public void SelectCharacter()
    {
        buttonValid.GetComponent<ButtonSelectValidation>().SetCharacterName(characterName);
    }

}
