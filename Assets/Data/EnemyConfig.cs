using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "EnemyConfig", menuName = "Enemies/Enemy Config", order = 0)]
public class EnemyConfig : ScriptableObject
{

    public float moverSpeed;
    public Sprite sprite;

}
