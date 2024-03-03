using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Different speeds we can modify
    public float speed = 5f;
    public float rotationSpeed = 90f;

    //Gets input
    private float horizontalInput;
    private float verticalInput;

    //Directions and velocities
    private Vector3 moveVelocity;
    private Vector3 turnVelocity;
    private Vector3 direction;

    //Controller for player
    private CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Gets input from keys
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //Sets direction
        direction = new Vector3(horizontalInput, 0, verticalInput);
        direction.Normalize();

        //Sets velocity
        moveVelocity = transform.forward * speed * verticalInput;
        turnVelocity = transform.up * rotationSpeed * horizontalInput;


        //Moves character (Movement and rotation wise)
        controller.Move(moveVelocity * Time.deltaTime);
        transform.Rotate(turnVelocity * Time.deltaTime);
    }
}
