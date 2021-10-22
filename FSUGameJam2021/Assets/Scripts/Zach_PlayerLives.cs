using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using TMPro;

public class Zach_PlayerLives : MonoBehaviour
{
    private Canvas canvas;

    private TextMeshProUGUI livesText; 
    private TextMeshProUGUI gameOverText; 
    [SerializeField] public int curLives;
    [SerializeField] public int maxLives = 3;

    public bool invincible = false; 

    private void Start()
    {
        canvas = GameObject.FindWithTag("Canvas").GetComponent<Canvas>();
        livesText = canvas.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        gameOverText = canvas.transform.GetChild(2).GetComponent<TextMeshProUGUI>();
        gameOverText.gameObject.SetActive(false);
        SetMaxLives(3);

    }

    public void SetMaxLives(int maxLives)
    {
        curLives = maxLives;
        livesText.text = curLives.ToString();
    }

    public void LoseLife()
    {
        curLives--; 
        StartCoroutine(Respawn());
        if(curLives <= 0)
        {
            curLives = 0; 
            this.gameObject.SetActive(false);
            gameOverText.gameObject.SetActive(true);
        }

        livesText.text = curLives.ToString();
    }

    IEnumerator Respawn()
    {
        invincible = true; 
        yield return new WaitForSeconds(2f);
        invincible = false; 
    }

}
