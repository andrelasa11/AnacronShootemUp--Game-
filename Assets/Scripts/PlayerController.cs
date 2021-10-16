using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Boundary
{
    public float xMin, xMax, yMin, yMax;
}

public class PlayerController : MonoBehaviour
{
    public Mover moverComponent;
    public float speed;
    public Boundary boundary;

    public Transform shootOrigin;
    public GameObject shootPrefab;

    private void Start()
    {
        moverComponent.speed = speed;
        InputProvider.OnHasShoot += OnHasShoot;
        InputProvider.OnDirection += OnDirection;

    }

    private void OnDirection(Vector3 direction)
    {
        moverComponent.direction = direction;
    }

    private void OnHasShoot()
    {
        Instantiate(shootPrefab, shootOrigin.position, shootOrigin.rotation);
    }

    void Update()
    {
        
        float x = Mathf.Clamp(transform.position.x, boundary.xMin, boundary.xMax);
        float y = Mathf.Clamp(transform.position.y, boundary.yMin, boundary.yMax);
        transform.position = new Vector3(x, y);


    }
}
