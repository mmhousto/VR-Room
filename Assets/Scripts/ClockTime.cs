using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockTime : MonoBehaviour
{

    private const float
        hoursToDegrees = 360f / 12f,
        minutesToDegrees = 360f / 60f,
        secondsToDegrees = 360f / 60f;

    public Transform hours, minutes, seconds;
    public bool analog;

    void Update()
    {
        if (analog)
        {
            TimeSpan timespan = DateTime.Now.TimeOfDay;
            hours.localRotation =
                Quaternion.Euler(90 + (float)timespan.TotalHours * hoursToDegrees, 0f, -90f);
            minutes.localRotation =
                Quaternion.Euler(90 + (float)timespan.TotalMinutes * minutesToDegrees, 0f, -90f);
            seconds.localRotation =
                Quaternion.Euler(90 + (float)timespan.TotalSeconds * secondsToDegrees, 0f, -90f);
        }
        else
        {
            DateTime time = DateTime.Now;
            hours.localRotation = Quaternion.Euler(90 + time.Hour * hoursToDegrees, 0f, -90f);
            minutes.localRotation = Quaternion.Euler(90 + time.Minute * minutesToDegrees, 0f, -90f);
            seconds.localRotation = Quaternion.Euler(90 + time.Second * secondsToDegrees, 0f, -90f);
        }
    }
}
