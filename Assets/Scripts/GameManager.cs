using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject[] enemyObjs;
    public Transform[] spawnPoints;

    public float maxSpawnDelay;
    public float curSpawnDelay;


    void Update()
    {
        curSpawnDelay += Time.deltaTime;

        if (curSpawnDelay > maxSpawnDelay)
        {
            SpawnEnemy();
            maxSpawnDelay = Random.Range(0.5f, 3f);
            curSpawnDelay = 0;
        }
    }

    void SpawnEnemy()
    {
        int ranEnemy = Random.Range(0, 1);
        int ranPoint = Random.Range(0, 5);
        Instantiate(
             enemyObjs[ranEnemy], spawnPoints[ranPoint].transform.position, spawnPoints[ranPoint].transform.rotation);
    }

    public void ClickStart()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void ClickExit()
    {
        Application.Quit();
    }



}
