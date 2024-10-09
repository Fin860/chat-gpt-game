using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public int playerNumber = 1;
    private int triangleSpeed = 7;
    private int triangleJump = 8;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) && playerNumber == 1) 
        {
            transform.position = transform.position + new Vector3(triangleSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow) && playerNumber == 1)
        {
            transform.position = transform.position + new Vector3(-triangleSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.Space) && playerNumber == 1)
        {
            transform.position = transform.position + new Vector3(0, triangleJump * Time.deltaTime);
        }
    }
}
