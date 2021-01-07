using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    [SerializeField]private float rotateSpeed = 19;

    void Start()
    {
        
    }

    void Update()
    {
        float horizontalRotate = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, Time.deltaTime * rotateSpeed * horizontalRotate);
    }
}
