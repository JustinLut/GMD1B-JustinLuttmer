using UnityEngine;
using System.Collections;

public class Score1000 : MonoBehaviour {

    void OnCollisionEnter(Collision c)
    {
        GameObject.Find("Game Manager").GetComponent<GameManager>().score += 1000;
    }

}
