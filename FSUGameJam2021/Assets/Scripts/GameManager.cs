using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private Canvas canvas;

    private TextMeshProUGUI gameOverText;
    TextMeshProUGUI waveNumberText;
    TextMeshProUGUI enemiesDestroyed;
    public int waveNumber;
    public int numEnemiesDestroyed;
    public bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false; 
        canvas = GameObject.FindWithTag("Canvas").GetComponent<Canvas>();
        numEnemiesDestroyed = 0;
        waveNumber = 1;
        waveNumberText = GameObject.Find("WaveNumber").GetComponent<TextMeshProUGUI>();
        enemiesDestroyed = GameObject.Find("EnemiesDestroyed").GetComponent<TextMeshProUGUI>();
        gameOverText = canvas.transform.GetChild(2).GetComponent<TextMeshProUGUI>();
        gameOverText.gameObject.SetActive(false);
    }

    private void Update()
    {
        waveNumberText.SetText(waveNumber.ToString());
        if (gameOver == true && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(1);
        }

        if (gameOver == true && Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    public void IncreaseEnemyCounter()
    {
        numEnemiesDestroyed++;
        enemiesDestroyed.SetText(numEnemiesDestroyed.ToString());
        if(numEnemiesDestroyed % 5 == 0)
        {
            UpdateWaveCounter();
        }
    }

    public void UpdateWaveCounter()
    {
        waveNumber++;
        waveNumberText.SetText(waveNumber.ToString());
    }

    public void GameOver()
    {
        gameOver = true; 
        gameOverText.gameObject.SetActive(true);

    }
}
