using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private GameManager gm;
    public GameObject[] enemyPrefab;
    private int yPos = 10;
    private int waveNumber = 1;
    private int enemyCount;
    private int enemyChoice;
    private int rand_yPos;

    public float cooldownTime = 3;
    private float nextFireTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyChoice = Random.Range(0, enemyPrefab.Length);
        rand_yPos = Random.Range(-yPos, yPos);
        enemyCount = FindObjectsOfType<EnemyMovement>().Length;
        if (enemyCount == 0)
        {
            SpawnEnemy(enemyChoice, rand_yPos);
        }
    }

    void SpawnEnemy(int enemyChoice, int rand_yPos)
    {
        if (Time.time > nextFireTime)
        {
            Instantiate(enemyPrefab[enemyChoice], new Vector2(25, rand_yPos), transform.rotation);
            nextFireTime = Time.time + cooldownTime;
        }
    }
}
