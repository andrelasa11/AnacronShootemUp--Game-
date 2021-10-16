using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy Wave", menuName = "Enemies/Wave Config", order = 0)]

public class EnemyWavesConfig : ScriptableObject
{

    public List<EnemyController> enemies;
    public float cadence;

}
