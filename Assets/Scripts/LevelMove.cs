using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMove : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public Vector3 MoveLevel;
    void FixedUpdate()
    {
        Rigidbody.AddForce(MoveLevel, ForceMode.Acceleration);
    }
}
