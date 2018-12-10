using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSelectValidation : MonoBehaviour {

    private string characterName;
    public void SetCharacterName(string name) { characterName = name; }
    
    public void ValidChoosenCharacter()
    {
        if (characterName != null) {
            GameManager gm = GameObject.Find("GameManager").GetComponent<GameManager>();            
            gm.InstantiateNewCharacter(characterName);
            gm.DestroySelectMenu();
        }

    }

}
