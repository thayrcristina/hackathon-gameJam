using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosao : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
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
