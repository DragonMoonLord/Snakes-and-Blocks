using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Player Player;
    public Vector3 MovementCam;

    private void Update()
    {
        transform.position = Player.transform.position + MovementCam;
    }
}
