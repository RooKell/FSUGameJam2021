using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedBehavior : MonoBehaviour
{
    public GameObject spit;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(spit, transform.position, spit.transform.rotation);
    }
}
