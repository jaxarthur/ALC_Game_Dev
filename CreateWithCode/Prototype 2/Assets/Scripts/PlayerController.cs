using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float maxX;
    public float speedX;
    private Vector3 lastPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        lastPosition = transform.position;

        //
        transform.position = new Vector3(Mathf.Clamp((horizontalInput * speedX * Time.deltaTime) + lastPosition.x, -1 * maxX, maxX), lastPosition.y, lastPosition.z);
    }
}
