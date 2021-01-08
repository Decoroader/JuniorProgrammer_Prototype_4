using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    private Vector3 enemyPos;
    private float range = 9;
    void Start()
    {
        SpawnEnemyWave(3);
    }

    void Update()
    {
        
    }
    void SpawnEnemyWave(int enemiesToSpawn)
	{
		for (int it = 0; it < enemiesToSpawn; it++)
		{
            enemyPos = new Vector3(Random.Range(-range, range), 0.5f, Random.Range(-range, range));

            Instantiate(enemyPrefab, enemyPos, Quaternion.identity);
        }
	}
}
