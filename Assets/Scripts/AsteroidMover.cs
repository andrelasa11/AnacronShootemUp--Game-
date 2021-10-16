using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMover : MonoBehaviour
{

    private Rigidbody2D rigidBodyReference;

    [SerializeField] private float speedMin, speedMax;

    private float speed;


    void Start()
    {
        speed = Random.Range(speedMin, speedMax);

        rigidBodyReference = GetComponent<Rigidbody2D>();

        rigidBodyReference.velocity = (Vector2.down * speed);
    }

    
}
