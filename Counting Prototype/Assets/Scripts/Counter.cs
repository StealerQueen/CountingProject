using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Counter : MonoBehaviour
{
    private TextMeshProUGUI counterText;
    private ResetButtonScript resetButtonScript;

    public int count = 0;

    private void Start()
    {
        counterText = GameObject.Find("ScoreText").GetComponent<TextMeshProUGUI>();
        resetButtonScript = GameObject.Find("ResetButton").GetComponent<ResetButtonScript>();

        counterText.text = "Score: " + count.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        resetButtonScript.isActive = true;
    }

    public void AddPoint()
    {
        count++;
        counterText.text = "Score: " + count.ToString();
    }
}
