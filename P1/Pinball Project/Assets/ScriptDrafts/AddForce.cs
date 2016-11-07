using UnityEngine;
using System.Collections;

public class AddForce : MonoBehaviour {

    public float forceApplied = 50;

	void OnCollisionEnter (Collision c)
    {
        if (c.gameObject.name == "Ball")
            c.gameObject.GetComponent<Rigidbody>().AddForce(0, forceApplied, 0);
    }
}
