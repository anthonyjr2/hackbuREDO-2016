using UnityEngine;
using System.Collections;

public class ActivateCrash : MonoBehaviour {

    Rigidbody2D rb2;
    Rigidbody2D rb1;

    void Start()
    {
        
    }

    IEnumerator timer()
    {
        yield return new WaitForSeconds(1.2f);
        Destroy(GameObject.Find("pc2"));
        Destroy(GameObject.Find("pc1"));
    }

    // Update is called once per frame
    void Update () {

	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        rb2 = GameObject.Find("pc2").GetComponent<Rigidbody2D>();
        rb1 = GameObject.Find("pc1").GetComponent<Rigidbody2D>();
        if (other.tag == "Player")
        {
            Debug.Log("start pc2");
            rb2.velocity = new Vector2(-7, 0);
            Debug.Log("start pc1");
            rb1.velocity = new Vector2(8, 0);
            StartCoroutine(timer());
        }

    }
}
