using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    private GameObject gameManager;

    [SerializeField]
    private bool isWarriorAlive;

    [SerializeField]
    private bool isArcherAlive;

    [SerializeField]
    private bool isPicklockAlive;

    [SerializeField]
    private Vector2 spawnPosition; 
    public Vector2 GetSpawnPosition() { return spawnPosition; }

    [SerializeField]
    private GameObject player;
    private GameObject instancePlayer;

    //[SerializeField]
    //choose who start

    [SerializeField]
    private GameObject warrior;
    private GameObject instanceWarrior;

    private void Awake()
    {
        gameManager = GameObject.Find("GameManager");
        gameManager.GetComponent<GameManager>().SetIsWarriorAlive(isWarriorAlive);
        gameManager.GetComponent<GameManager>().SetIsArcherAlive(isArcherAlive);
        gameManager.GetComponent<GameManager>().SetIsPicklockAlive(isPicklockAlive);
                
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
