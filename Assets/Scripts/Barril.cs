using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barril : MonoBehaviour {

    public GameObject barril;
    public GameObject dk;

    private GameObject barrilInstanciado;
    private GameObject dkInstanciado;

    float velocidadeBarril = 0.08f;
    float velocidadeDK = 0.08f;
    float tempo = 0.0f;

    float y = 5.86f;
    float ydk = 6.09f;
    float[] x = { -2.322f + 2.5f, -1.845f + 2.5f, -1.367f + 2.5f, -0.825f + 2.5f, -0.306f + 2.5f, 0.34f + 2.5f, 0.864f + 2.5f, 1.417f + 2.5f, 1.866f + 2.5f, 2.316f + 2.5f };
    bool ativador = true;
    bool dir;
    float i;
    int j;

    // Use this for initialization
    void Start () {
        dkInstanciado = (GameObject)Instantiate(dk, new Vector3(x[j], ydk, 0), Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
        tempo += Time.deltaTime;

        if(ativador)
        {
            i = Random.Range(0.0f, 9.0f);
            j = Mathf.RoundToInt(i);
            ativador = false;
        }

        if(dkInstanciado.transform.position.x > x[j] + 0.005)
        {
            DKMove(dkInstanciado, j, false);
        }
        if (dkInstanciado.transform.position.x < x[j] - 0.005)
        {
            DKMove(dkInstanciado, j, true);
        }

        if (tempo > 2.2f)
        {
            tempo = 0.0f;

            barrilInstanciado = (GameObject)Instantiate(barril, new Vector3(x[j], y, 0), Quaternion.identity);
            ativador = true;
        }
        if(barrilInstanciado.transform.position.y > -4.08107f)
        {
            Move(barrilInstanciado);
        }
        else
        {
            Destroy(barrilInstanciado);
        }
    }

    void Move(GameObject barril)
    {
        barril.transform.Translate(0, -velocidadeBarril, 0);
    }

    void DKMove(GameObject dk, int j, bool dir) //true = direita; false = esquerda
    {
        if (dir)
        {
            dk.transform.Translate(velocidadeDK, 0, 0);
        }
        if (!dir)
        {
            dk.transform.Translate(-velocidadeDK, 0, 0);
        }
    }
}
