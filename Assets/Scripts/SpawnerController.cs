using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public List<GameObject> enemiesPrefabs;
    public List<EnemyConfig> enemiesConfigs;

    public Vector3 spawnReferencePosition;
    public Quaternion spawnRotation;

    public int amountToSpawn;
    public float spawnCadence;
    public float initialWaitTime;

    private void Start()
    {
        StartCoroutine(EnemySpawnerCoroutine());
    }

    private IEnumerator EnemySpawnerCoroutine()
    {
        yield return new WaitForSeconds(initialWaitTime);

        for (int i = 0; i < amountToSpawn; i++)
        {
            Vector3 randomPosition = new Vector3(Random.Range(-spawnReferencePosition.x, spawnReferencePosition.x), spawnReferencePosition.y, spawnReferencePosition.z);
            SpawnEnemy(randomPosition, spawnRotation);

            yield return new WaitForSeconds(spawnCadence);
        }
    }

    public void SpawnEnemy(Vector3 enemyPosition, Quaternion rotation)
    {
        int randomIndex = Random.Range(0, enemiesPrefabs.Count);
        var enemyInstance = Instantiate(enemiesPrefabs[randomIndex], enemyPosition, rotation);
        var enemyController = enemyInstance.GetComponent<EnemyController>();

        if (enemyController != null)
        {
            int randomConfigIndex = Random.Range(0, enemiesConfigs.Count);
            enemyController.config = enemiesConfigs[randomConfigIndex];
        }
    }
}
