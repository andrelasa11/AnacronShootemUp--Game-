using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public float destroyTime;

    public void DoDestroy()
    {
        Destroy(gameObject, destroyTime);
    }

}
