using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveRandomSpawnSystem : MonoBehaviour
{
    public GameObject naveInstance;
    [SerializeReference] float timeToSpawn;
    [SerializeField] int enemiesToSpawn;
    int currentEnemiesSpawned;
    void Start()
    {
        currentEnemiesSpawned = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeToSpawn <= 0)
        {
            if (currentEnemiesSpawned <= enemiesToSpawn)
            {
                Vector3 randomPos = new Vector3(Random.Range(100, -100), 0, Random.Range(100, -100));
                SpawnNave(randomPos);
            }
            else
            {
                return;
            }
        }
        else
        {
            timeToSpawn -= Time.deltaTime;
        }

    }

    void SpawnNave(Vector3 position)
    {
        Instantiate(naveInstance, position, Quaternion.identity);
        currentEnemiesSpawned += 1;
    }
}
