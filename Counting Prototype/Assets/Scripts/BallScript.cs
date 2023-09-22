using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private Rigidbody ballRB;
    private GameObject powerLevel;

    public float force;

    public Vector3 startPosition;
    public Quaternion startRotation;

    public bool isForced = false;

    // Start is called before the first frame update
    void Start()
    {
        ballRB = GetComponent<Rigidbody>();
        powerLevel = GameObject.Find("PowerLevel");

        startPosition = transform.position;
        startRotation = transform.rotation;
    }

    private void Update()
    {
        Debug.Log(powerLevel.transform.localScale.x);
    }

    public void ForceStart()
    {
        ballRB.AddForce(transform.up * force * (powerLevel.transform.localScale.x / 2), ForceMode.Impulse);
        isForced = true;
    }
}
