using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int forMagnatude = 1000;
    public int turnMagnatude = 1000;
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
        rb.AddRelativeForce(Vector3.forward * forMagnatude * vertInput);
        rb.AddRelativeTorque(Vector3.up * turnMagnatude * horizInput);
    }
}
