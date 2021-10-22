using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMovement : MonoBehaviour
{

    public float speed = 5f;
    private BoxCollider2D enemyCol;
    private CapsuleCollider2D arrow;
    private GameObject enemy;
    private GameObject player;
    public bool noFlip = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        enemy = GameObject.Find("Enemy");
        //enemyCol = enemy.GetComponent<BoxCollider2D>();
        arrow = GetComponent<CapsuleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        FlipArrowDirection();
    }

    void FlipArrowDirection()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        //if (player.GetComponent<PlayerMovement>().lastDir == true && noFlip == false)
        //{
        //    transform.Translate(Vector2.right * speed * Time.deltaTime);
        //    noFlip = true;
        //}

        //else if (player.GetComponent<PlayerMovement>().lastDir == false)
        //{
        //    transform.Translate(Vector2.left * speed * Time.deltaTime);

        //}
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(enemy);     
    }
}
