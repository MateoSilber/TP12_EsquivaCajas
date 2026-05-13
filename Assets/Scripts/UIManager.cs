using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI textoTiempo;
    float tiempo;
    public bool gameOver = false;
    public bool empezo = false;

    void Update()
    {
        if(empezo && !gameOver){
            tiempo += Time.deltaTime;
            textoTiempo.text = "Tiempo:"+ tiempo.ToString("F2");
        }
    }

    public void Play()
    {
        empezo = true;
    }
}