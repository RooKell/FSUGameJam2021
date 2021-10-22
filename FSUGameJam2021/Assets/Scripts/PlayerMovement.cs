using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float playerSpeed = 10f;
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
    }

    void ShootArrow()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(arrow, transform.position, arrow.transform.rotation);
        }
    }
}
