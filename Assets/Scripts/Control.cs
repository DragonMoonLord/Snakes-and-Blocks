using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Control : MonoBehaviour
{
    private Rigidbody rb;
    private float Move = 0f;
    public float Speed;

    public Rigidbody Rigidbody;
    public Vector3 Forcee;

    public Text Text;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Move = Input.GetAxisRaw("Horizontal") * Speed;
        Text.text = " ";
    }

    private void FixedUpdate()
    {
        Vector3 vector = new Vector3(rb.velocity.x, rb.velocity.y, Move * 10f);
        rb.velocity = vector;
        Rigidbody.AddForce(-Forcee, ForceMode.Acceleration);
    }
}
