using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speedPlayer = 1.5f;
    private Rigidbody playerRigid;
    void Start()
    {
        playerRigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float playerMoveF_B = Input.GetAxis("Vertical");
        playerRigid.AddForce(Vector3.forward * playerMoveF_B * speedPlayer, ForceMode.Impulse);
    }
}
