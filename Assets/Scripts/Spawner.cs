using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerupPrefab;
    
    private int waveNumber = 1;
    private float range = 9;

    private List<GameObject> Enemies = new List<GameObject>();

    void Start()
    {
        SpawnEnemyWave(waveNumber);
    }

    void Update()
    {
        //enemyCount = FindGameObjectsWithTag<Enemy>().Length;
        if (CheckEnemiesList() < 1)
            SpawnEnemyWave(++waveNumber);
    }
    void SpawnEnemyWave(int enemiesToSpawn)
	{
        Enemies.Clear();

        for (int it = 0; it < enemiesToSpawn; it++)
		{
            Vector3 enemyPos = new Vector3(Random.Range(-range, range), 0.5f, Random.Range(-range, range));
            Enemies.Add(Instantiate(enemyPrefab, enemyPos, Quaternion.identity));
        }
        
        Vector3 powerupPos = new Vector3(Random.Range(-range, range), 0.5f, Random.Range(-range, range));
        Instantiate(powerupPrefab, powerupPos, Quaternion.identity);
    }

    int CheckEnemiesList()
	{
        int countEnemies = 0;
        foreach (var enemy in Enemies)
        {
            if (enemy != null)
                countEnemies++;
        }
        return countEnemies;
    }
}
