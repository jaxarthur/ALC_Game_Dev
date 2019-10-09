using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float fire;
    public float horizontalInput;
    public float maxX;
    public float speedX;
    public float projectileCoolDown;
    public float coolDownTimer;
    public int projectileCount;
    public float projectileSpread;
    public GameObject projectile;
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

        //fire projectile
        fire = Input.GetAxis("Jump");

        coolDownTimer += Time.deltaTime;

        if (fire > 0 && coolDownTimer > projectileCoolDown)
        {
            for (int i = projectileCount * -1; i < projectileCount+1; i++)
            {
                Instantiate(projectile, transform.position + Vector3.forward, Quaternion.AngleAxis(i * projectileSpread, Vector3.up));
            }
            coolDownTimer = 0;
        }
    }
}
