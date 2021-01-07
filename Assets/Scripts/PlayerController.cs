using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speedPlayer = 1.5f;
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
}
