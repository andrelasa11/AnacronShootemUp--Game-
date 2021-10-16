using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoScroller : MonoBehaviour
{
    public float scrollSpeed = 0.07f;

    [SerializeField] private MeshRenderer meshComponent;

    void Update()
    {
        Vector2 offset = new Vector2(0, Time.time * scrollSpeed);
        meshComponent.material.mainTextureOffset = offset;
               
    }
}
