using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 20.0f; // Full throttle.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the vehicle forward. Time.deltaTime normalizes
        // speed to meters per second.
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
