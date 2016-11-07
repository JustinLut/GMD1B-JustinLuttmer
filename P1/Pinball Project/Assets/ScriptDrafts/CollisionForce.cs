using UnityEngine;
using System.Collections;

public class CollisionForce : MonoBehaviour
{

    public Transform coordinates;
    public Vector3 direction;
    public Rigidbody rb;
    public float force;

    // Use this for initialization
    void Start()
    {

        direction = coordinates.position;

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter()
    {
        rb.AddForce(direction * force);
    }
}
