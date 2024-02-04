using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{

    public float speed = 2.0f;
    public Rigidbody cubeRb;

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

    public virtual void MoveCube()
    {
        cubeRb.AddForce(transform.up * speed);
    }
}
