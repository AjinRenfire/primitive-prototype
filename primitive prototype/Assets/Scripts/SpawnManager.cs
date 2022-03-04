using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject EnemyPrefab;

    private int _waveCount = 1;
    private int _countOfEnemies;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemies(_waveCount);
    }

    // Update is called once per frame
    void Update()
    {
        _countOfEnemies = GameObject.FindGameObjectsWithTag("Enemy").Length;
        if (_countOfEnemies == 0) SpawnEnemies(++_waveCount);
    }

    void SpawnEnemies(int waveCount)
    {
        float spawnX, spawnZ;




        for (int i = 0; i < waveCount; i++)
        {
            spawnX = Random.Range(-10, 10);
            spawnZ = Random.Range(-11, -1);

            Vector3 spawnPostion = new Vector3(spawnX, 0.5f, spawnZ);

            Instantiate(EnemyPrefab, spawnPostion, EnemyPrefab.transform.rotation);
        }
    }
}
