using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xRotate = 0f;
    [SerializeField] float yRotate = 0.65f;
    [SerializeField] float zRotate = 0f;
    void Update()
    {
        transform.Rotate(xRotate, yRotate, zRotate);
    }
}
