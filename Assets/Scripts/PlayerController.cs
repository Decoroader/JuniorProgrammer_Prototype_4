using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool hasPowerup;
    public GameObject powerupIndicator;

    private float speedPlayer = 1.1f;
    private float powerupStrenght = 25;
    private Rigidbody playerRigid;
    private GameObject focalPoint;
    private Vector3 offsetIndPos = new Vector3(0, 0.55f, 0);


    void Start()
    {
        playerRigid = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("FocalPoint");
    }

    void Update()
    {
        float playerMoveF_B = Input.GetAxis("Vertical");
        playerRigid.AddForce(focalPoint.transform.forward * playerMoveF_B * speedPlayer, ForceMode.Impulse);
        powerupIndicator.transform.position = transform.position + offsetIndPos;
    }
	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Powerup"))
		{
            hasPowerup = true;
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountdownRoutine());
            powerupIndicator.SetActive(hasPowerup);
		}
	}
	private void OnCollisionEnter(Collision collision)
	{
        if (collision.gameObject.CompareTag("Enemy") && hasPowerup)
        {
            Rigidbody enemyRb = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position);
            enemyRb.AddForce(awayFromPlayer * powerupStrenght, ForceMode.Impulse);
            Debug.Log("Player contaced with " + collision.gameObject + " wth powerup is " + hasPowerup);
        }
	}

    IEnumerator PowerupCountdownRoutine()
	{
        yield return new WaitForSeconds(5);
        hasPowerup = false;
        powerupIndicator.SetActive(hasPowerup);
    }
}
