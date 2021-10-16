using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKeyboardListener : MonoBehaviour, IInputeable
{
    public void GetDirection(Vector3 direction)
    {
        InputProvider.TriggerDirection(direction);
    }

    public void ShootPressed()
    {
        InputProvider.TriggerOnHasShoot();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Shoot"))
        {
            ShootPressed();
        }

        GetDirection(new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
        
    }
}
