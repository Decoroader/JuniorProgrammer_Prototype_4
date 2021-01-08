using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool hasPowerup;

    private float speedPlayer = 1.1f;
    private Rigidbody playerRigid;
    private GameObject focalPoint;
    void Start()
    {
        playerRigid = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("FocalPoint");
    }

    void Update()
    {
        float playerMoveF_B = Input.GetAxis("Vertical");
        playerRigid.AddForce(focalPoint.transform.forward * playerMoveF_B * speedPlayer, ForceMode.Impulse);
    }
	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Powerup"))
		{
            hasPowerup = true;
            Destroy(other.gameObject);
		}
	}
	private void OnCollisionEnter(Collision collision)
	{
        if (collision.gameObject.CompareTag("Enemy") && hasPowerup)
            Debug.Log("Player contaced with " + collision.gameObject + " wth powerup is " + hasPowerup);
	}
}
