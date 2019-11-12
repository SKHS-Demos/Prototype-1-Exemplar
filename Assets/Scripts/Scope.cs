using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scope : MonoBehaviour
{
    public float outer = 42.0f;

    // Start is called before the first frame update
    void Start()
    {
        public float inner = 24.0f;
    }

    // Update is called once per frame
    void Update()
    {
        float local = outer + inner;
    }
}
