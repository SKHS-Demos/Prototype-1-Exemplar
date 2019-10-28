using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject vehicle;
    [SerializeField] private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        // Calculate the distance between the camara and the vehicle.
        offset = vehicle.transform.position - transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = vehicle.transform.position - offset;
    }
}
