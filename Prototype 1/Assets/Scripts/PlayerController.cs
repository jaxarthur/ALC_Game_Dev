using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int forMagnatude = 70000;
    public int turnMagnatude = 70000;
    private float horizInput;
    private float vertInput;
    private Rigidbody rb;
    private Vector3 move;
    private Vector3 rotate;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        vertInput = Input.GetAxis("Vertical");
        horizInput = Input.GetAxis("Horizontal");

        move = Vector3.forward * forMagnatude * vertInput;
        rotate = Vector3.up * turnMagnatude * horizInput;

        //Move Car Forward
        rb.AddRelativeForce(move);
        rb.AddRelativeTorque(rotate);
    }
}
