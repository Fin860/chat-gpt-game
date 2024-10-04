using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class playerMovement : MonoBehaviour
{
    public int playerTriangle = 1;
    private int triangleSpeed = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) && playerTriangle == 1 && transform.position.x <= 3f) 
        {
            transform.position = transform.position + new Vector3(triangleSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A) && playerTriangle == 1 && transform.position.x <= 3f)
        {
            transform.position = transform.position + new Vector3(-triangleSpeed * Time.deltaTime, 0, 0);
        }
    }
}
