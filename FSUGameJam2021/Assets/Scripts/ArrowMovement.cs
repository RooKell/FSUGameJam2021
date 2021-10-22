using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMovement : MonoBehaviour
{

    public float speed = 5f;
    private BoxCollider2D enemyCol;
    private CapsuleCollider2D arrow;
    private GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.Find("Enemy");
        //enemyCol = enemy.GetComponent<BoxCollider2D>();
        arrow = GetComponent<CapsuleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(enemy);     
    }
}
