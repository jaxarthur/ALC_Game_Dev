using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenObsitcles : MonoBehaviour
{
    public GameObject Obs;
    private GameObject topClone;
    private GameObject bottomClone;
    public int dist = 50;
    public int space = 10;
    public int amount = 10;
    public int begin = 50;
    public int range = 25;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < amount; i++)
        {
            int hole = (int)Random.Range(range * -1, range);
            int topBottom = hole + space;
            int bottomTop = hole - space;
            int topMiddle = (100 + topBottom) / 2;
            int bottomMiddle = (-100 + bottomTop) / 2;

            topClone = Instantiate(Obs, new Vector3(0, topMiddle, i * dist + begin), Quaternion.AngleAxis(0,Vector3.forward));
            bottomClone = Instantiate(Obs, new Vector3(0, bottomMiddle, i * dist + begin), Quaternion.AngleAxis(0, Vector3.forward));

            topClone.transform.localScale = new Vector3(100, Mathf.Abs(topBottom - topMiddle) * 2, 1);
            bottomClone.transform.localScale = new Vector3(100, Mathf.Abs(bottomTop - bottomMiddle) * 2, 1);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
