using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject asteroidObject;
    [SerializeField] float minSpawnTime;
    [SerializeField] float maxSpawnTime;
    [SerializeField] float minSpawnDistance;
    [SerializeField] float maxSpawnDistance;

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    void Update()
    {
        
    }

    IEnumerator SpawnEnemy()
    {
        
        while (true)
        {
            float spawnDelay = Random.Range(minSpawnTime, maxSpawnTime);
            Vector2 position = new Vector2(transform.position.x, Random.Range(minSpawnDistance, maxSpawnDistance));
            Instantiate(asteroidObject, position, transform.rotation);
            yield return new WaitForSecondsRealtime(spawnDelay);
        }

    }
}
