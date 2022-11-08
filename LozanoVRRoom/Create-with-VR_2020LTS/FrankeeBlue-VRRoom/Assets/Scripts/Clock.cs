using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;

public class Clock : MonoBehaviour
{
    public GameObject secondHand;
    public GameObject minuteHand;
    public GameObject hourHand;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DateTime nowTime = DateTime.Now;
        
        float secondDegree = (nowTime.Second / 60f) *  360f;
        secondHand.transform.localRotation = Quaternion.Euler(new Vector3(secondDegree, 0, 0));

        float minuteDegree = (nowTime.Minute / 60f) * 360f;
        minuteHand.transform.localRotation = Quaternion.Euler(new Vector3(minuteDegree, 0, 0));

        float hourDegree = (nowTime.Hour / 12f) * 360f;
        hourHand.transform.localRotation = Quaternion.Euler(new Vector3(hourDegree, 0, 0));
    }
}
