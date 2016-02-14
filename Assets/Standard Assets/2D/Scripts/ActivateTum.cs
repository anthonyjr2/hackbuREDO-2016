using UnityEngine;
using System.Collections;

public class ActivateTum : MonoBehaviour
{

    Rigidbody2D rb;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        rb = GameObject.Find("tum").GetComponent<Rigidbody2D>();
        if (other.tag == "Player")
        {
            Debug.Log("start tum");
            rb.velocity = new Vector2(-5, 0);
        }
    }
}
