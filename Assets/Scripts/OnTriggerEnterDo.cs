using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnCollisionDo : MonoBehaviour
{

    [SerializeField] private UnityEvent action;

    private GameObject collisionee;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collisionee = collision.gameObject;
        action.Invoke();
    }

    public void DestroyCollisionee()
    {
        if (collisionee != null)
            Destroy(collisionee);
    }

}
