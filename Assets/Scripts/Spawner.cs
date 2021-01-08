using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    private Vector3 enemyPos;
    private float range = 9;
    void Start()
    {
        enemyPos = new Vector3(Random.Range(-range, range), 0.5f, Random.Range(-range, range));
        //Instantiate(enemyPrefab, enemyPos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
