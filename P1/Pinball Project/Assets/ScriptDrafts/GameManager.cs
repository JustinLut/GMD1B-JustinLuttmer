using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{

    public int score;
    public int lives;
    public float power;
    public GameObject prefab;
    public GameObject pinballSpawn;
    public bool ballSpawn;


    void Start()
    {
        lives = 3;
        score = 0;
    }

    public void SpawnPinball()
    {
        GameObject pinball = (GameObject)Instantiate(prefab, pinballSpawn.GetComponent<Transform>()
        .position, pinballSpawn.GetComponent<Transform>().rotation);

        pinball.GetComponent<Rigidbody>().velocity = pinballSpawn.GetComponent<Transform>()
        .transform.forward * power;
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (ballSpawn)
            {
                SpawnPinball();
                ballSpawn = false;

            }
        }
    }
}