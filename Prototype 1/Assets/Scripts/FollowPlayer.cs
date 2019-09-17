using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0, 5, -7);
    public Vector3 rotation = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotation = player.transform.eulerAngles;

        transform.position = player.transform.position + offset;
        transform.rotation = player.transform.rotation;
    }
}
