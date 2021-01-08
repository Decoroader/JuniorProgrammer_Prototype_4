using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody enemyRb;
    private GameObject player;
    private float speedEnemy = .55f;

    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speedEnemy, ForceMode.Impulse);
        //enemyRb.AddForce(player.transform.forward * speedEnemy, ForceMode.Impulse);

        if (transform.position.y < -11)
            Destroy(gameObject);
    }
}   
