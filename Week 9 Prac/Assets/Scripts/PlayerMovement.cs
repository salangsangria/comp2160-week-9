using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //left
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(speed * Time.deltaTime * (-1), 0, 0);
        }
        //right
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime * (1), 0, 0);
        }
        //up
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, speed * Time.deltaTime * (1), 0);
        }
        //down
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, speed * Time.deltaTime * (-1), 0);
        }
    }
}
