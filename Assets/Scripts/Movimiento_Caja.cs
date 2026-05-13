using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Caja : MonoBehaviour
{
    public float speedFall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(FindObjectOfType<UIManager>().empezo)
            {
                transform.Translate(0,-speedFall * Time.deltaTime,0);
            }
    }
}
