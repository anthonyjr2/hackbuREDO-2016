using UnityEngine;
using System.Collections;

public class ScrollingBackgound : MonoBehaviour {
    public float scrollSpeed;
    public float tileSize;
    private Vector2 startPos;
	// Use this for initialization
	void Start () {
        startPos=transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        float x = Mathf.Repeat(scrollSpeed, 1);
        Vector2 offset = new Vector2(startPos.x, 0);
        GetComponent<Renderer>().sharedMaterial.SetTextureOffset("fullBackground", offset);
        Debug.Log("scroll");
	}
    void OnDisable()
    {
        GetComponent<Renderer>().sharedMaterial.SetTextureOffset("fullBackground", startPos);
    }
}
