using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private float velocity = 1f;

    private void Awake()
    {
        transform.position = Vector3.zero;
    }


    private void FixedUpdate()
    {
        transform.Translate(Camera.main.transform.right * velocity * Time.deltaTime);
    }
}
