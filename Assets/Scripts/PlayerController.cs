using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float turnSpeed;
    public float forwardInput;
    public float horizontalInput;
    // Update is called once per frame
    void Update()
    {
        // Move the vehicle forward
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
