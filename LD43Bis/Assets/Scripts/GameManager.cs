using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
        
    private bool isWarriorAlive;
    public void SetIsWarriorAlive(bool isHe) { isWarriorAlive = isHe; }
    public bool GetIsWarriorAlive() { return isWarriorAlive; }

    private bool isArcherAlive;
    public void SetIsArcherAlive(bool isHe) { isArcherAlive = isHe; }
    public bool GetIsArcherAlive() { return isArcherAlive; }

    private bool isPicklockAlive;
    public void SetIsPicklockAlive(bool isHe) { isPicklockAlive = isHe; }
    public bool GetIsPicklockAlive() { return isPicklockAlive; }

    [SerializeField]
    private GameObject audioLevel;
    private GameObject instanceAudioLevel;

    private GameObject canvas;

    [SerializeField]
    private GameObject selectMenu;
    private GameObject instanceSelectMenu;

    [SerializeField]
    private GameObject warrior;

    [SerializeField]
    private GameObject archer;

    [SerializeField]
    private GameObject picklock;

    private int currentLevel;

    // Use this for initialization
    void Start () {

        DontDestroyOnLoad(gameObject);

        isWarriorAlive = true;
        isArcherAlive = true;
        isPicklockAlive = true;

        canvas = GameObject.Find("Canvas");

    }
	
	// Update is called once per frame
	void Update () {

        if (isWarriorAlive == false && isArcherAlive == false && isPicklockAlive == false)
        {
            GameOver();
        }

	}

    private void GameOver()
    {
        print("Game Over");
    }

    private void ShowSelectMenu()
    {
        canvas = GameObject.Find("Canvas");
        instanceSelectMenu = Instantiate(selectMenu, canvas.GetComponent<Transform>());
    }

    public void DestroySelectMenu()
    {
        Destroy(instanceSelectMenu);
    }

    public void ChangeCharacter()
    {
        if (isWarriorAlive == true || isArcherAlive == true || isPicklockAlive == true)
        {
            ShowSelectMenu();
        }
    }

    public void InstantiateNewCharacter(string name)
    {        
        Vector2 spawnPos = GameObject.Find("Grid").GetComponent<LevelManager>().GetSpawnPosition();
        GameObject player = GameObject.Find("Player");
        player.GetComponent<Transform>().position = spawnPos;

        if (name == "Warrior")
        {
            Instantiate(warrior, player.GetComponent<Transform>());
        }
        else if (name == "Archer")
        {
            Instantiate(archer, player.GetComponent<Transform>());
        }
        else if (name == "Picklock")
        {
            Instantiate(picklock, player.GetComponent<Transform>());
        }
    }

    private void PlayAudioLevel()
    {
        if (instanceAudioLevel == null)
        {
            instanceAudioLevel = Instantiate(audioLevel);
        }
    }

    public void LaunchLevel1()
    {
        PlayAudioLevel();
                
        SceneManager.LoadScene(1);

        currentLevel = 1;        
    }

    public void LaunchLevel2()
    {
        PlayAudioLevel();
    }

    public void LaunchLevel3()
    {
        PlayAudioLevel();
    }

}
