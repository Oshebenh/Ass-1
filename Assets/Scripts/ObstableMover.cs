using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObstacleMover : MonoBehaviour
{
    public float speed = 4f;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime; 
    }
}
