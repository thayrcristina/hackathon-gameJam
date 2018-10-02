using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FantasmaAzul : MonoBehaviour {

    float[] x = {2.5f, 3.9f, 3.9f, 2.8f, 2.8f, 2.2f, 2.2f, 1.7f, 1.7f, 2.2f, 2.2f };
    float[] y = {3.5f, 3.5f, 5.4f, 5.4f, 4.9f, 4.9f, 4.6f, 4.6f, 4.1f, 4.1f, 3.5f};
    int ponto = 0;
    float velocidade = 0.01f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x > x[ponto] + 0.005f || transform.position.x < x[ponto] - 0.005f)
        {
            transform.Translate((-(transform.position - new Vector3(x[ponto], y[ponto], 0)) / (transform.position - new Vector3(x[ponto], y[ponto], 0)).magnitude) * velocidade);
        }
        if (transform.position.y > y[ponto] + 0.005f || transform.position.y < y[ponto] - 0.005f)
        {
            transform.Translate((-(transform.position - new Vector3(x[ponto], y[ponto], 0)) / (transform.position - new Vector3(x[ponto], y[ponto], 0)).magnitude) * velocidade);
        }
        if(transform.position.x < x[ponto] + 0.005f && transform.position.x > x[ponto] - 0.005f && transform.position.y < y[ponto] + 0.005f && transform.position.y > y[ponto] - 0.005f)
        {
            if (ponto < x.Length - 1)
            {
                ponto += 1;
            }
            else
            {
                ponto = 0;
            }
        }
        print(ponto);
	}

    void OnTriggerEnter2D(Collider2D coll)

    {


        if (coll.name == "PacMan")
        {
            Destroy(coll.gameObject);
            GameOverScript.morreu = true;
        }
    }
}
