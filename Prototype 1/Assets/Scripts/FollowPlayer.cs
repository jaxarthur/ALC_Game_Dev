using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0, 5, -7);
    public Vector3 rotation = new Vector3();
    public int dist = 5;
    public int rot = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //align with player
        transform.rotation = player.transform.rotation;

        transform.position = player.transform.position + Vector3.back * dist + Vector3.up * 5;
        transform.rotation = Quaternion.Slerp(player.transform.rotation, Quaternion.AngleAxis(rot, Vector3.right),.5f);
    }
}
