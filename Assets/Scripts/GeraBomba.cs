﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeraBomba : MonoBehaviour
{

    float tempo;
    float[] x = { 0.2f, 1.14f, 2.25f, 2.79f, 3.89f, 4.78f };
    float[] y = { 0.28f, 0.74f, 1.39f, 1.83f, 2.46f, 3.5f, 4.13f, 4.65f, 5.3f };

    public GameObject bomba;
    public GameObject explosao;

    private GameObject bombaInstanciado;
    private GameObject explosaoInstanciado;

    int k = 0;
    int l = 0;

    // Use this for initialization
    void Start()
    {

       bombaInstanciado = (GameObject) Instantiate(bomba, new Vector3(x[k], y[l], 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        tempo += Time.deltaTime;
        if(tempo > 3.0f)
        {
            tempo = 0.0f;

            Destroy(bombaInstanciado);
            Destroy(explosaoInstanciado);

            explosaoInstanciado = (GameObject)Instantiate(explosao, new Vector3(x[k], y[l], 0), Quaternion.identity);
            
            float i = Random.Range(0.0f, 5f);
            float j = Random.Range(0.0f, 8f);

            k = Mathf.RoundToInt(i);
            l = Mathf.RoundToInt(j);

            bombaInstanciado = (GameObject) Instantiate(bomba, new Vector3(x[k], y[l], 0), Quaternion.identity);

            
        }
    }

}


