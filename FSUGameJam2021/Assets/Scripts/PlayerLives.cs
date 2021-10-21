using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLives : MonoBehaviour
{

    [SerializeField] private int curLives;
    [SerializeField] private int maxLives = 3;

    public void SetMaxLives(int maxLives)
    {
        curLives = maxLives;
    }
}
