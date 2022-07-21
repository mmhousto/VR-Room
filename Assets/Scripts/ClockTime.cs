using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockTime : MonoBehaviour
{

    public GameObject hourHand, minuteHand, secondHand;

    private DateTime currentTime;

    string seconds, minutes, hours;

    // Start is called before the first frame update
    void Start()
    {
        SetTimeClock();
        InvokeRepeating(nameof(UpdateTimeClock), 1, 1);
    }

    void SetTimeClock()
    {
        currentTime = DateTime.Now;
        seconds = currentTime.ToString("ss");
        minutes = currentTime.ToString("mm");
        hours = currentTime.ToString("hh");

        float secondRotation = (Convert.ToInt32(seconds) * 6);
        secondHand.transform.Rotate(new Vector3(0, secondRotation, 0));

        float minuteRotation = (Convert.ToInt32(minutes) * 6);
        minuteHand.transform.Rotate(new Vector3(0, minuteRotation, 0));

        float hourRotation = (Convert.ToInt32(hours) * 30);
        hourHand.transform.Rotate(new Vector3(0, hourRotation, 0));
    }

    void UpdateTimeClock()
    {
        secondHand.transform.Rotate(new Vector3(0, 6, 0));
    }

    void UpdateMinuteHand()
    {
        minuteHand.transform.Rotate(new Vector3(0, 6, 0));
    }

    private void OnTriggerExit(Collider other)
    {
        UpdateMinuteHand();
    }
}
