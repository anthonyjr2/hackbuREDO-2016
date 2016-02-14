using UnityEngine;
using System.Collections;

public class TumBounce : MonoBehaviour
{

    Rigidbody2D rb;

    public bool Move = true;
    public Vector3 MoveVector = Vector3.up;
    public float MoveRange = 2.0f;

    private TumBounce bounceObject;
    Vector3 startPosition;
    // Use this for initialization
    void Start()
    {
        bounceObject = this;
        startPosition = bounceObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Move)
            bounceObject.transform.position = startPosition + MoveVector * (MoveRange * Mathf.Sin(Time.timeSinceLevelLoad * 6));
    }
}
