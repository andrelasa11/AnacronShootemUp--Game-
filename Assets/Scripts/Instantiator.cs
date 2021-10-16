using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{

    public GameObject prefab;


    public void DoInstantiate()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }
}
