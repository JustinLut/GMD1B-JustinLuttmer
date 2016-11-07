using UnityEngine;
using System.Collections;

public class Score250 : MonoBehaviour {

    void OnCollisionEnter(Collision c)
    {
        GameObject.Find("Game Manager").GetComponent<GameManager>().score += 250;
    }

}
