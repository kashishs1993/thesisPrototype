using UnityEngine;
using TMPro;
using System;

public class TimerDisplay : MonoBehaviour
{
    float countDown =0.0f;
    public TMP_Text timeDisplay;
    public bool timeOn = true;

    public void Update()
    {
        if (timeOn == true)
        {
            countDown += Time.deltaTime;
        }
        if (timeOn == false)
        {

        }
        double b = System.Math.Round(countDown);
        timeDisplay.text = b.ToString();

    }
}
