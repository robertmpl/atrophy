using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [Header("General")]
    public float movementSpeed = 2; // Speed the player moves at

    InputAction moveAction;

    private void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move"); // Get inputs for movement
    }

    void Update()
    {
        // Get input using Vector2 for use with linear velocity
        Vector2 moveValue = moveAction.ReadValue<Vector2>();

        // Seperate inputs for axis specific tasks
        float verticalInputAxis = moveValue.y;
        float horizontalInputAxis = moveValue.x;

        // Apply input axis to linear velocity with adjustable movement speed variable
        gameObject.GetComponent<Rigidbody2D>().linearVelocity = movementSpeed * moveValue;
    }
}
