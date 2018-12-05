using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Manager : MonoBehaviour {

    [SerializeField]
    private Vector2 spawnPosition;

    [SerializeField]
    private GameObject player;
    private GameObject instancePlayer;


    private void Awake()
    {
        instancePlayer = Instantiate(player, new Vector3(spawnPosition.x, spawnPosition.y, 0), Quaternion.identity);
        instancePlayer.name = "Player";
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
