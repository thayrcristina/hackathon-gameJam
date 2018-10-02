using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacManAsteroid : MonoBehaviour {

    public GameObject asteroid;
    private GameObject asteroidInstanciado;
    float velocidade;

	// Use this for initialization
	void Start () {
        velocidade = 2.0f;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = (Vector2)transform.position + Vector2.up * 0.05f;
            transform.eulerAngles = new Vector3(0, 0, 90);
            if (Input.GetKey(KeyCode.Space))
            {
                Atirar(0);
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position = (Vector2)transform.position + Vector2.right * 0.05f;
                transform.eulerAngles = new Vector2(0, 0);
                if (Input.GetKey(KeyCode.Space))
                {
                    Atirar(2);
                }
            }
            else
            {
                if (Input.GetKey(KeyCode.DownArrow))
                {
                    transform.position = (Vector2)transform.position + Vector2.down * 0.05f;
                    transform.eulerAngles = new Vector3(0, 0, 270);
                    if (Input.GetKey(KeyCode.Space))
                    {
                        Atirar(1);
                    }
                }
                else
                {
                    if (Input.GetKey(KeyCode.LeftArrow))
                    {
                        transform.position = (Vector2)transform.position + Vector2.left * 0.05f;
                        transform.eulerAngles = new Vector2(0, 180);
                        if (Input.GetKey(KeyCode.Space))
                        {
                            Atirar(3);
                        }
                    }
                }
            }
        }
        
    }

    void Atirar(int i)
    {

        if(i == 0){
            asteroidInstanciado = (GameObject)Instantiate(asteroid, this.transform.position + new Vector3(0, 0.2f, 0), Quaternion.identity);
            asteroidInstanciado.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 5, 0);
        }
        if(i == 1)
        {
            asteroidInstanciado = (GameObject)Instantiate(asteroid, this.transform.position + new Vector3(0, -0.2f, 0), Quaternion.identity);
            asteroidInstanciado.GetComponent<Rigidbody2D>().velocity = new Vector3(0, -5, 0);
        }
        if(i == 2)
        {
            asteroidInstanciado = (GameObject)Instantiate(asteroid, this.transform.position + new Vector3(0.2f, 0, 0), Quaternion.identity);
            asteroidInstanciado.GetComponent<Rigidbody2D>().velocity = new Vector3(5, 0, 0);
        }
        if (i == 3)
        {
            asteroidInstanciado = (GameObject)Instantiate(asteroid, this.transform.position + new Vector3(-0.2f, 0, 0), Quaternion.identity);
            asteroidInstanciado.GetComponent<Rigidbody2D>().velocity = new Vector3(-5, 0, 0);
        }

        Destroy(asteroidInstanciado, 2.0f);
    }
}
