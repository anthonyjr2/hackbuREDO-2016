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
                Debug.Log("test");
                Application.LoadLevel(2);
                // SceneManager.LoadScene(SceneManager.GetSceneAt(0).path);
                //Destroy(other.gameObject);

            }
        }
    }
}
