using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float playerSpeed = 10f;
    private int yPos = 10;
    private int xPos = 20;
    [SerializeField] private float horizontalInput;
    [SerializeField] private float verticalInput;
    public GameObject arrow;

    // Start is called before the first frame update
    void Start()
    {
        
}

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        ShootArrow();
    }

    void PlayerMove()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * Time.deltaTime * playerSpeed * horizontalInput);
        transform.Translate(Vector3.up * Time.deltaTime * playerSpeed * verticalInput);

        if (transform.position.y > 8)
        {
            transform.position = new Vector3(transform.position.x, 8, transform.position.z);
        }
        if (transform.position.y < -8)
        {
            transform.position = new Vector3(transform.position.x, -8, transform.position.z);
        }
        if (transform.position.x > 30)
        {
            transform.position = new Vector3(30, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -18)
        {
            transform.position = new Vector3(-18, transform.position.y, transform.position.z);
        }
    }

    void ShootArrow()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(arrow, transform.position, arrow.transform.rotation);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }
    }
}
