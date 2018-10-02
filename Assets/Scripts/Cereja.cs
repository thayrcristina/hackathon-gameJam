using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cereja : MonoBehaviour {

    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.name == "PacMan")
        { //Comando para apenas o pacman comer
                Destroy(gameObject);
                ScoreScript.scoreValue += 50;
        }

    }
}
