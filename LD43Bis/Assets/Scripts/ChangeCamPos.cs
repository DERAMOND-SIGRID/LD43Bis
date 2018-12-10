using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamPos : MonoBehaviour {

    [SerializeField]
    private Vector2 cameraPosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            if (Camera.main.GetComponent<Transform>().position != new Vector3(cameraPosition.x, cameraPosition.y, Camera.main.GetComponent<Transform>().position.z))
            {
                Camera.main.GetComponent<Transform>().position = new Vector3(cameraPosition.x, cameraPosition.y, Camera.main.GetComponent<Transform>().position.z);
            }
        }
    }

}
