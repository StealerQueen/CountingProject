using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggeredObstacleScript : MonoBehaviour
{
    private Rigidbody ballRB;

    private float powerForce;
    private float minPowerForce = 75;
    private float maxPowerForce = 100;

    private Counter counterScript;

    // Start is called before the first frame update
    void Start()
    {
        ballRB = GameObject.FindGameObjectWithTag("Ball").GetComponent<Rigidbody>();
        counterScript = GameObject.Find("StopTrigger").GetComponent<Counter>();
    }

    // Update is called once per frame
    void Update()
    {
        powerForce = Random.Range(minPowerForce, maxPowerForce);
    }

    private void OnCollisionEnter(Collision collision)
    {
        ballRB.AddForce((transform.position - ballRB.position).normalized * powerForce, ForceMode.Impulse);
        counterScript.AddPoint();
    }
}
