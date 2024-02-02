using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float playerMoveSpeed = 5f;
    void Start()
    {
    
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * playerMoveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * playerMoveSpeed;
        transform.Translate(xValue, 0f, zValue);
    }
}
