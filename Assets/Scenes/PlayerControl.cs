using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 5f;

    float thisISADecimal = 3.14f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 currentPos = transform.position;
            
        
        {
            if (Input.GetKey(KeyCode.W))
            //{newPos.z + = 0.5f;}
            currentPos.z = currentPos.z + speed * Time.deltaTime;

            if (Input.GetKey(KeyCode.S))
            //{newPos.z - = 0.5f;}
            currentPos.z = currentPos.z - speed * Time.deltaTime;

            if (Input.GetKey(KeyCode.A))
            //{newPos.x - = 0.5f;}
            currentPos.x = currentPos.x - speed * Time.deltaTime;

            if (Input.GetKey(KeyCode.D))
            //{newPos.x + = 0.5f;}
            currentPos.x = currentPos.x + speed * Time.deltaTime;

            //newPos.x + = 0.5f;

            //transform.position = new Vector3(3, 3, -10);

            transform.position = currentPos;

        }

    }
}
