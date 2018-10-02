using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacMan : MonoBehaviour {

    float velocidade;

	// Use this for initialization
	void Start () {
        velocidade = 2;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = (Vector2)transform.position + Vector2.up * 0.05f;
            transform.eulerAngles = new Vector3(0, 0, 90);
        }
        else
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position = (Vector2)transform.position + Vector2.right * 0.05f;
                transform.eulerAngles = new Vector2(0, 0);
            }
            else
            {
                if (Input.GetKey(KeyCode.DownArrow))
                {
                    transform.position = (Vector2)transform.position + Vector2.down * 0.05f;
                    transform.eulerAngles = new Vector3(0, 0, 270);
                }
                else
                {
                    if (Input.GetKey(KeyCode.LeftArrow))
                    {
                        transform.position = (Vector2)transform.position + Vector2.left * 0.05f;
                        transform.eulerAngles = new Vector2(0, 180);
                    }
                }
            }
        }
    }
}
