using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectilePhysics : MonoBehaviour
{
    public Vector3 force;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(force, ForceMode.Force);
    }
}
