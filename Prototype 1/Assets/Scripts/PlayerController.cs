using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int forMagnatude = 10;
    public float turnMagnatude = .3f;
    private float horizInput;
    private float vertInput;
    public Rigidbody rb;

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
        //Move Car Forward
        rb.velocity = (Vector3.forward * forMagnatude * vertInput);
        rb.angularVelocity = (Vector3.up * turnMagnatude * horizInput);
    }
}
