using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animals;
    public float spawnRateMin;
    public float spawnRateMax;
    public float waveMin;
    public float waveMax;
    public float spawnHeight;
    public float spawnRange;

    public float elapsedTime;
    public float goalTime;
    public float waveSize;
    // Start is called before the first frame update
    void Start()
    {
        goalTime = Random.Range(spawnRateMin, spawnRateMax);
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime > goalTime)
        {
            waveSize = Random.Range(waveMin, waveMax);
            elapsedTime = 0;
            goalTime = Random.Range(spawnRateMin, spawnRateMax);

            for (int i = 0; i < waveSize; i++)
            {
                Instantiate(animals[Random.Range(0, animals.Length)], new Vector3(Random.Range(-spawnRange, spawnRange), 0, spawnHeight), Quaternion.AngleAxis(180, Vector3.up));
            }

            
        }
        
    }
}
