using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnTriggerEnterDo : MonoBehaviour
{

    [SerializeField] private UnityEvent baseActions; //A��es feitas em todos os objetos
    [SerializeField] private UnityEvent specificActions; // A��es feitas nos objetos que n�o s�o ignorados
    [SerializeField] List<string> tagsToIgnore;

    private GameObject collisionee;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        baseActions.Invoke();

        foreach (string ignoredTag in tagsToIgnore)
        {
            if(collision.CompareTag(ignoredTag))
            {
                return;
            }
            
        }

        specificActions.Invoke();
    }

    public void DestroyCollisionee()
    {
        if (collisionee != null)
            Destroy(collisionee);
    }

}
