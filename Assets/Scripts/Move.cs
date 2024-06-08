using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 5.0f;
    public float depthSpeed = 2.0f; // adjust this value to control the depth movement

    private Rigidbody rb;
    private float depth = 0.0f; // store the current depth value

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        // adjust the depth movement based on the vertical input
        depth += moveVertical * depthSpeed * Time.deltaTime;
        transform.position += new Vector3(movement.x, movement.y, depth);

       //rb.velocity = movement * speed;
    }
}