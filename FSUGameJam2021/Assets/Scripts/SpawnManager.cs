using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] enemyPrefab;
    private int yPos = 10;
    private int waveNumber = 1;
    private int enemyCount;
    private int enemyChoice;
    private int rand_yPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemyChoice = Random.Range(0, enemyPrefab.Length);
        rand_yPos = Random.Range(-yPos, yPos);
        enemyCount = FindObjectsOfType<EnemyMovement>().Length;
        if (enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemy(enemyChoice, rand_yPos, waveNumber);
        }
    }

    void SpawnEnemy(int enemyChoice, int rand_yPos, int waveNumber)
    {
        for (int i = 0; i <= waveNumber; i++)
        {
            Instantiate(enemyPrefab[enemyChoice], new Vector2(25, rand_yPos), transform.rotation);
        }
    }
}
