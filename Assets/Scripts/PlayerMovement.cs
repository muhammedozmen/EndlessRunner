using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private float moveSpeed;
    private float jumpSpeed;
    private float gravityScale;
    private float slideSpeed;
    private int laneIndex;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        moveSpeed = 30f;
        jumpSpeed = 60f;
        gravityScale = 40f;
        slideSpeed = 100f;
        laneIndex = 0;
    }

    private void Update()
    {
        rb.AddForce(Vector3.forward * moveSpeed, ForceMode.Force);
        rb.AddForce(Physics.gravity * gravityScale * Time.fixedDeltaTime, ForceMode.Acceleration);
        if (Input.GetButtonDown("Jump") && rb.velocity.y == 0)
        {
            rb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (laneIndex != 1)
            {
                rb.AddForce(Vector3.right * slideSpeed, ForceMode.Impulse);
                laneIndex++;
            }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (laneIndex != -1)
            {
                rb.AddForce(Vector3.left * slideSpeed, ForceMode.Impulse);
                laneIndex--;
            }
        }

    }
}
