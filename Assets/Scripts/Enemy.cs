using UnityEngine;

public class Enemy : MonoBehaviour
{
    //private Spawner spawnerForEnemy;
    private Rigidbody enemyRb;
    private GameObject player;
    private float speedEnemy = .75f;

    private int tempEnemyNumber;

    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        //spawnerForEnemy = GetComponent<Spawner>();  
    }

    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speedEnemy, ForceMode.Impulse);
        //enemyRb.AddForce(player.transform.forward * speedEnemy, ForceMode.Impulse);

        if (transform.position.y < -11)
        {
			//tempEnemyNumber = spawnerForEnemy.GetEnemiesNumber();
			//spawnerForEnemy.SetEnemiesNumber(--tempEnemyNumber);
			Spawner.enemiesNumber--;
            Destroy(gameObject);
        }
    }
}   
