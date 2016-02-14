using UnityEngine;
using System.Collections;

public class WinScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Application.LoadLevel(1);
        }
        else if (Input.GetKeyDown("x"))
        {
            Application.Quit();
        }
	}
}
