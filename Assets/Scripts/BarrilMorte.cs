using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrilMorte : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D coll)

    {
        if (coll.name == "PacMan")
        {
            Destroy(coll.gameObject);
            GameOverScript.morreu = true;
        }
    }
}
