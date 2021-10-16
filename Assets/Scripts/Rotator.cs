using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float rotateMin, rotateMax;

    private float rotateSpeed;


    void Start()
    {
        rotateSpeed = Random.Range(rotateMin, rotateMax);
    }
        
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, rotateSpeed) * Time.deltaTime);
    }
}

