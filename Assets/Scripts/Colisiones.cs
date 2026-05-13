using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisiones : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Player"))
        {
            Destroy(col.gameObject);
            GetComponent<Movimiento_Caja>().speedFall = 0;
            FindObjectOfType<UIManager>().gameOver = true;
        }
        else if(col.gameObject.CompareTag("Piso"))
        {
            int[] posicionesX = {-2, 0, 2};
            int xRandom = posicionesX[Random.Range(0, posicionesX.Length)];
            transform.position = new Vector3(xRandom, 7, 0);
            GetComponent<Movimiento_Caja>().speedFall += 0.3f;
            

            
        }
    }
}