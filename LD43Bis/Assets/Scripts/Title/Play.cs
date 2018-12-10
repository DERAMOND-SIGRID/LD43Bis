using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour {

    [SerializeField]
    private GameObject gameManager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetPlay()
    {
        gameManager.GetComponent<GameManager>().LaunchLevel1();
    }

}
