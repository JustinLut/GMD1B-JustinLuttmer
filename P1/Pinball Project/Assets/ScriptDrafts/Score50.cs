using UnityEngine;
using System.Collections;

public class Score50 : MonoBehaviour {

	void OnCollisionEnter (Collision c)
    {
        GameObject.Find("Game Manager").GetComponent<GameManager>().score += 50;
    }
	
	}

