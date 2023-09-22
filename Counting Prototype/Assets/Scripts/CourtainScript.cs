using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourtainScript : MonoBehaviour
{
    public GameObject courtain;
    private bool ballIn = false;

    public Vector3 startPosition;

    private void Start()
    {
        startPosition = courtain.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(ballIn && courtain.transform.position.z >= transform.position.z && courtain.transform.position.y <= transform.position.y)
        {
            courtain.transform.Translate(Vector3.back * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        ballIn = true;
    }
}
