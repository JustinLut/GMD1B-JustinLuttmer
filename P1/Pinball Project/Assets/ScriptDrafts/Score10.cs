using UnityEngine;
using System.Collections;

public class Score10 : MonoBehaviour {

    void OnCollisionEnter(Collision c)
    {
        GameObject.Find("Game Manager").GetComponent<GameManager>().score += 10;
    }

}
