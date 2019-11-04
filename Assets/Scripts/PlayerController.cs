using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 20.0f; // Full throttle.
    [SerializeField] private float yawRate = 10.0f; // Degrees per second.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    [SerializeField] private float vertInput;
    [SerializeField] private float horzInput;
    void Update()
    {
        vertInput = Input.GetAxis("Vertical");
        horzInput = Input.GetAxis("Horizontal");

        // Move the vehicle forward. Time.deltaTime normalizes
        // speed to meters per second.
        transform.Translate(speed * vertInput * Time.deltaTime * Vector3.forward);
        transform.Rotate(yawRate * horzInput * Time.deltaTime * Vector3.up);
    }
}
