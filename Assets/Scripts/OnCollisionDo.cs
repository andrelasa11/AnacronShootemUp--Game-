using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnTriggerEnterDo : MonoBehaviour
{

    [SerializeField] private UnityEvent baseActions; //Ações feitas em todos os objetos
    [SerializeField] private UnityEvent specificActions; // Ações feitas nos objetos que não são ignorados
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
