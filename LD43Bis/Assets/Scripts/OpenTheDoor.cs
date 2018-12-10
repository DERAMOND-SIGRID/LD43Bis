using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class OpenTheDoor : MonoBehaviour {

    [SerializeField]
    private List<GameObject> ennemiesInRoom;

    [SerializeField]
    private UnityEvent doorEvent;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        doorEvent.Invoke();
	}

    public void OpenDoorByCleaningRoom()
    {
        bool isTheRoomClean = true;

        foreach (GameObject go in ennemiesInRoom)
        {
            if (go != null)
            {
                isTheRoomClean = false;
            }
        }

        if (isTheRoomClean == true)
        {
            OpenDoor();
        }

    }

    public void OpenFinalDoor() { }

    public void OpenDoor()
    {
        gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
        gameObject.GetComponent<SpriteRenderer>().sprite = null;
    }

}
