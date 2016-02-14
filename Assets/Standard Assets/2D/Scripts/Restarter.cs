using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
    public class Restarter : MonoBehaviour
    {
        
        private void OnTriggerEnter2D(Collider2D other)
        {
           
            if (other.tag == "Player")
            {
                print("dope");
                other.transform.position = new Vector3(0, 1.1f, 0);
                GameObject.Find("EndScreen").transform.position = new Vector2(1, 4);
                GameObject.Find("JohnCena").GetComponent<UnityStandardAssets._2D.Platformer2DUserControl>().enabled = false;
                //GetComponent<UnityStandardAssets._2D.Platformer2DUserControl>().enabled = false;


            }
        }
    }
}
