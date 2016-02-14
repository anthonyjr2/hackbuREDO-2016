using UnityEngine;
using System.Collections;

public class Twit : MonoBehaviour
{
    public bool Move = true;
    public Vector3 MoveVector = Vector3.up;
    public float MoveRange = 2.0f;

    private Twit bounceObject;

    Vector3 startPosition;
    void Start()
    {
        bounceObject = this;
        startPosition = bounceObject.transform.position;
    }
    void Update()
    {
        if (Move) 
            bounceObject.transform.position = startPosition + MoveVector * (MoveRange * Mathf.Sin(Time.timeSinceLevelLoad * 2));

    }
}
 