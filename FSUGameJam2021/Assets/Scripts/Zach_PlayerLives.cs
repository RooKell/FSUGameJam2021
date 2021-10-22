using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using TMPro;

public class Zach_PlayerLives : MonoBehaviour
{
    private Canvas canvas;
    private GameManager gm;

    private TextMeshProUGUI livesText; 
    [SerializeField] public int curLives;
    [SerializeField] public int maxLives = 3;

    public bool invincible = false; 

    private void Start()
    {
        this.gameObject.SetActive(true);
        canvas = GameObject.FindWithTag("Canvas").GetComponent<Canvas>();
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        livesText = canvas.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
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
            gm.GameOver();

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
