using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInimigo : MonoBehaviour
{
    public GameObject spawnObject;
    public Vector3 spawnPoint;
    public int maxX = 10;
    public int maxY = 10;
    public int timeTilNextSpawn = 5;
    int x = 0;
    int y = 0;
    float timer = 0;

    void Start()
    {
        timer = 0;
        spawnPoint.x = x;
        spawnPoint.y = y;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        Spawn();
    }

    void Spawn()
    {
        if (timer >= timeTilNextSpawn)
        {
            x = Random.Range(-8, maxX);
            y = Random.Range(8, maxY);
            spawnPoint.x = x;
            spawnPoint.y = y;
            Instantiate(spawnObject, spawnPoint, Quaternion.identity);
            timer = 0;
        }
    }
}