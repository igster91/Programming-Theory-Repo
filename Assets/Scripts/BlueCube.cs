using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCube : CubeManager
{
    
    // Start is called before the first frame update
    void Start()
    {
        cubeRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveCube();
    }

    public override void MoveCube()
    {
        cubeRb.AddForce(transform.up * speed * 100);
    }
}
