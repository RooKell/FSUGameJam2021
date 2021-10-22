using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    private GameObject player;
    private Rigidbody2D enemyRb;
    private Vector2 movement;
    public float enemySpeed = 5f;
    


    // Start is called before the first frame update
    void Start()
    {
        enemyRb = this.GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        enemyRb.rotation = angle;
        direction.Normalize();
        movement = direction;
    }

    private void FixedUpdate()
    {
        EnemyMove(movement);
    }

    void EnemyMove(Vector2 direction)
    {
        enemyRb.MovePosition((Vector2)transform.position + (direction * enemySpeed * Time.deltaTime));
    }
}
