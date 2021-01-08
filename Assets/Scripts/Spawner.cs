using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerupPrefab;
    
    private int waveNumber = 1;

    private float range = 9;

    //private int enemiesNumber;
    public static int enemiesNumber;

    void Start()
    {
        SpawnEnemyWave(waveNumber);

    }

    void Update()
    {
        if (enemiesNumber < 1)
        {
            SpawnEnemyWave(++waveNumber);
        }
    }
    void SpawnEnemyWave(int enemiesToSpawn)
	{
        enemiesNumber = enemiesToSpawn;
		for (int it = 0; it < enemiesToSpawn; it++)
		{
            Vector3 enemyPos = new Vector3(Random.Range(-range, range), 0.5f, Random.Range(-range, range));
            Instantiate(enemyPrefab, enemyPos, Quaternion.identity);
        }
        
        Vector3 powerupPos = new Vector3(Random.Range(-range, range), 0.5f, Random.Range(-range, range));
        Instantiate(powerupPrefab, powerupPos, Quaternion.identity);
    }
    //_______________!!!!!!!!!!!!!!!!!!!!!__________________________
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
    //_______________!!!!!!!!!!!!!!!!!!!!!__________________________
}
