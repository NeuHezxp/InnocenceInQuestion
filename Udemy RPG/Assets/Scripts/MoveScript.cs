using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    private Animator animator;
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
    public Rigidbody2D rigidbody;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
    public float movementSpeed = 5.0f;
    // Start is called before the first frame update
    private void Start()
    {
        // Get the Animator component
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = Vector2.zero;  // Initialize movement vector

        // Check for input and adjust the movement vector accordingly
        if (Input.GetKey(KeyCode.W))
        {
            movement.y = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            movement.y = -1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            movement.x = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movement.x = 1;
        }
        // Set the animator parameters
        animator.SetFloat("DirectionX", movement.x);
        animator.SetFloat("DirectionY", movement.y);
        animator.SetFloat("Speed", movement.magnitude);
        movement.Normalize();  // Normalize the movement vector to ensure consistent speed in all directions

        // Apply the movement to the Rigidbody2D component
        rigidbody.velocity = movement * movementSpeed;

        // Control the animation based on movement
        float moveSpeed = movement.magnitude;
        animator.SetFloat("Speed", moveSpeed);

        // You may also want to handle the case when the player stops moving
        if (moveSpeed < 0.1f)
        {
            // Set the animation parameter to make it idle
            animator.SetFloat("Speed", 0f);
        }
    }
}
