using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidBody;
    float timeToWait = 3f;
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidBody.useGravity = false; 
    }

    void Update()
    {
        if (Time.time > timeToWait) {
            renderer.enabled = true;
            rigidBody.useGravity = true;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player") {
            GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}
