using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using UnityEngine;
using Random=UnityEngine.Random;


public class SpawnManager : MonoBehaviour
{
    public GameObject HeatEnemy;
    public GameObject TreeEnemy;
    private float spawnRangeX = 22;
    private float spawnPosZ = 25;
    private float spawnPosY = 1;
    private float startDelay = 1;
    private float spawnInterval = 1.5f;
    private int level = 1;
   

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnEnemy() 
    {

        int i;

        // Add enemies depending on the level.
        for (i = 1; i < (level + 2) * 2; i++) 
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnPosY, spawnPosZ);
            Instantiate(HeatEnemy, spawnPos, HeatEnemy.transform.rotation);

            // Spawn a few less trees than heat enemies.
            if (i % 3 == 0)
            {
                Vector3 treeSpawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnPosY, spawnPosZ);
                Instantiate(TreeEnemy, treeSpawnPos, TreeEnemy.transform.rotation);
            }
        } 
        
    }

}
