using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    private Vector3 enemyPos;
    private float range = 9;
    //private int enemiesNumber;
    public static int enemiesNumber;
    void Start()
    {
        SpawnEnemyWave(3);
    }

    void Update()
    {
        if (enemiesNumber < 1)
            SpawnEnemyWave(3);
    }
    void SpawnEnemyWave(int enemiesToSpawn)
	{
        enemiesNumber = enemiesToSpawn;
		for (int it = 0; it < enemiesToSpawn; it++)
		{
            enemyPos = new Vector3(Random.Range(-range, range), 0.5f, Random.Range(-range, range));

            Instantiate(enemyPrefab, enemyPos, Quaternion.identity);
        }
	}
    public void EnemiesNumberDecrement()
	{
        enemiesNumber--;
    }
    public int GetEnemiesNumber()
	{
        return enemiesNumber;
    }
    public void SetEnemiesNumber(int enNumb)
	{
        enemiesNumber = enNumb;
    }

}
