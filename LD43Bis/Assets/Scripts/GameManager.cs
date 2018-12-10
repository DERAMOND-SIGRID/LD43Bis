using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
        
    private bool isWarriorAlive;
    public void SetIsWarriorAlive(bool isHe) { isWarriorAlive = isHe; }

    private bool isArcherAlive;
    public void SetIsArcherAlive(bool isHe) { isArcherAlive = isHe; }

    private bool isPicklockAlive;
    public void SetIsPicklockAlive(bool isHe) { isPicklockAlive = isHe; }

    [SerializeField]
    private GameObject audioLevel;
    private GameObject instanceAudioLevel;

    private GameObject canvas;

    [SerializeField]
    private GameObject selectMenu;
    private GameObject instanceSelectMenu;

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
