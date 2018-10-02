using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pedra : MonoBehaviour
{
    public GameObject fantasmaM1;
    public GameObject fantasmaM2;
    private GameObject fantasmaM1I;
    private GameObject fantasmaM2I;
    public GameObject fantasmaP1;
    public GameObject fantasmaP2;
    private GameObject fantasmaP1I;
    private GameObject fantasmaP2I;

    void OnTriggerEnter2D(Collider2D coll)
    {

        if (coll.name.Contains("FantasmaLaranjaGrande"))
        {
            fantasmaM1I = (GameObject)Instantiate(fantasmaM1, this.transform.position, Quaternion.identity);
            fantasmaM2I = (GameObject)Instantiate(fantasmaM2, this.transform.position, Quaternion.identity);
            Destroy(coll.gameObject);
            ScoreScript.scoreValue++;
        }
        if (coll.name.Contains("FantasmaLaranjaMedio"))
        {
            fantasmaP1I = (GameObject)Instantiate(fantasmaP1, this.transform.position, Quaternion.identity);
            fantasmaP2I = (GameObject)Instantiate(fantasmaP2, this.transform.position, Quaternion.identity);
            Destroy(coll.gameObject);
            ScoreScript.scoreValue++;
        }
        if (coll.name.Contains("FantasmaLaranjaPequeno"))
        {
            Destroy(coll.gameObject);
            ScoreScript.scoreValue++;
        }
    }
}
