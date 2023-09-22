using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonScript : MonoBehaviour
{
    private BallScript ballScript;
    
    public GameObject powerLevel;
    
    private Vector3 scaleChange;
    
    private bool plusScale = true;
    public bool changeScale = true;

    [SerializeField] float minPower = 1.25f;
    [SerializeField] float maxPower = 2.5f;

    private void Start()
    { 
        scaleChange = new Vector3(2, 0, 0);
    }

    private void Update()
    {
        ballScript = GameObject.FindWithTag("Ball").GetComponent<BallScript>();

        if (powerLevel.transform.localScale.x < maxPower && plusScale && changeScale)
        {
            powerLevel.transform.localScale += scaleChange * Time.deltaTime;
        }
        if (powerLevel.transform.localScale.x >= maxPower)
        {
            plusScale = false;
        }
        if (!plusScale && powerLevel.transform.localScale.x > minPower && changeScale)
        {
            powerLevel.transform.localScale -= scaleChange * Time.deltaTime;
        }
        if (powerLevel.transform.localScale.x <= minPower)
        {
            plusScale = true;
        }
    }

    private void OnMouseDown()
    {
        if(!ballScript.isForced) ballScript.ForceStart();
        changeScale = false;
    }
}
