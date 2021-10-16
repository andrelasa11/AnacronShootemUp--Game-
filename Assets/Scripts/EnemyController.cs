using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [HideInInspector]
    public EnemyConfig config;

    [SerializeField] private SpriteRenderer spriteRenderer;

    private Mover mover;

    private void Start()
    {
        mover = GetComponent<Mover>();

        if (mover != null)
        {
            mover.speed = config.moverSpeed;
        }

        if (config.sprite != null)
        {
            spriteRenderer.sprite = config.sprite;
        }
    }


}
