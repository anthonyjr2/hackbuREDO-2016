using UnityEngine;
using System.Collections;

public class GoWin : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("test");
            Application.LoadLevel(3);
            // SceneManager.LoadScene(SceneManager.GetSceneAt(0).path);
            //Destroy(other.gameObject);

        }
    }
}
