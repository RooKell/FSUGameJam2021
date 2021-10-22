using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    private GameObject player;
    private GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && player.GetComponent<Zach_PlayerLives>().invincible == false)
        {
            Debug.Log("player touched enemy");
            player.GetComponent<Zach_PlayerLives>().LoseLife();
        }

        else if(other.gameObject.tag == "PlayerProjectile")
        {
            Debug.Log("enemy down");
            gm.GetComponent<GameManager>().IncreaseEnemyCounter();
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
