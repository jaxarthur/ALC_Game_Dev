using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveOutOfBounds : MonoBehaviour
{
    public float upperBound;
    public float lowerBound;
    public float rightBound;
    public float lefBound;
    public Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;

        if (pos.z > upperBound || pos.x > rightBound || pos.x < lowerBound)
        {
            Destroy(gameObject);
        } else if (pos.z < lowerBound)
        {
            Debug.Log("Gameover");
            Destroy(gameObject);
        }
    }
}
