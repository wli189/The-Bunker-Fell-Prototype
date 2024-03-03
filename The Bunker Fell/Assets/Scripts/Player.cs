using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Different speeds we can modify
    public float speed = 20f;
    public float rotationSpeed = 90f;

    //Gets input
    private float horizontalInput;
    private float verticalInput;


    // Start is called before the first frame update
    void Start() {}

    // Update is called once per frame
    void Update()
    {
        //Gets input from keys
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //Move object
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
    }
}
