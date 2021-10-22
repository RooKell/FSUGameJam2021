using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float playerSpeed = 10f;
    [SerializeField] private float horizontalInput;
    [SerializeField] private float verticalInput;
    public GameObject arrow;
    public GameObject arrowSpawner; 

    public float cooldownTime = 2;
    private float nextFireTime = 0; 

    public bool lastDir;
    public bool lastDirVert;
    private SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        arrowSpawner = this.transform.GetChild(0).gameObject;
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
            if(horizontalInput < 0)
            {
                sprite.flipX = false;
                lastDir = false;
            }
            else if(horizontalInput > 0)
            {
                sprite.flipX = true;
                lastDir = true;
            }

           if(verticalInput < 0)
           {
               sprite.flipY = false;
               lastDirVert = false;
           }

           else if(verticalInput > 0)
           {
               sprite.flipY = true;
               lastDirVert = true; 
           }

            else 
            {
                sprite.flipX = lastDir;
                sprite.flipY = lastDirVert;
            }


    }

    void ShootArrow()
    {
        if(Time.time > nextFireTime)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GameObject arrowClone = Instantiate(arrow, arrowSpawner.transform.position, arrowSpawner.transform.rotation);
                if (lastDir == true)
                {
                    arrowClone.GetComponent<SpriteRenderer>().flipX = false;

                }
                else if (lastDir == false)
                {
                    arrowClone.GetComponent<SpriteRenderer>().flipX = true;
                }

                nextFireTime = Time.time + cooldownTime;
            }
        }
    }
}
