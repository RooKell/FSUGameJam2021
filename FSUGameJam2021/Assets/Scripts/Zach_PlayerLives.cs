using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using TMPro;

public class Zach_PlayerLives : MonoBehaviour
{
    private Canvas canvas;

    private TextMeshProUGUI livesText; 
    [SerializeField] private int curLives;
    [SerializeField] private int maxLives = 3;

    private void Start()
    {
        canvas = GameObject.FindWithTag("Canvas").GetComponent<Canvas>();
        livesText = canvas.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        SetMaxLives(3);

    }

    public void SetMaxLives(int maxLives)
    {
        curLives = maxLives;
        livesText.text = curLives.ToString();
    }



}
