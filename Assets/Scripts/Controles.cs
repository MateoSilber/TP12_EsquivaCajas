using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controles : MonoBehaviour
{
    public int distance = 2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(distance, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-distance, 0, 0);
        }
        if (transform.position.x > 2){
                transform.position = new Vector3(2, transform.position.y, transform.position.z);
            }

        if (transform.position.x < -2){
            transform.position = new Vector3(-2, transform.position.y, transform.position.z);
        }   
    }
}