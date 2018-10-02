using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FantasmaPequeno : MonoBehaviour
{

    float velocidade = 0.5f;

    int k;

    IEnumerator Start()
    {
        gameObject.GetComponent<CircleCollider2D>().enabled = false;
        GetComponent<Rigidbody2D>().velocity = new Vector3(0, velocidade, 0);
        yield return new WaitForSeconds(1);
        gameObject.GetComponent<CircleCollider2D>().enabled = true;
    }

    void OnTriggerEnter2D(Collider2D coll)

    {
        if (coll.name == "maze")
        {
            float i = Random.Range(1.0f, 4000000000.0f);
            i = i / 1000000000;
            int j = Mathf.RoundToInt(i);

            if (k == j)
            {
                if (j < 3)
                {
                    j += 1;
                }
                else
                {
                    j -= 1;
                }
            }

            print(this.transform.position.x);

            if (this.transform.position.x < 0.18f)
            {
                j = 0;
            }
            if (this.transform.position.x > 4.8f)
            {
                j = 1;
            }
            if (this.transform.position.y > 5.0f)
            {
                j = 3;
            }
            if (this.transform.position.y < 0.0f)
            {
                j = 2;
            }

            if (j == 0)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector3(velocidade, 0, 0);
            }
            if (j == 1)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector3(-velocidade, 0, 0);
            }
            if (j == 2)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector3(0, velocidade, 0);
            }
            if (j == 3)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector3(0, -velocidade, 0);
            }

            k = j;
        }

        if (coll.name == "PacMan")
        {
            Destroy(coll.gameObject);
            GameOverScriptSpaceInvaders.morreu = true;
        }
    }
}
