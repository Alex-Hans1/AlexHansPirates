using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timer_text;
    float timer_time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer_time += Time.deltaTime;
        int minutes = 10 + Mathf.FloorToInt(timer_time / 60);
        int seconds = Mathf.FloorToInt(timer_time % 60);
        timer_text.text = string.Format("{0:00}:{1:00}am", minutes, seconds);
        if(minutes >= 12)
        {

        }
        Debug.Log(minutes);
        Debug.Log(seconds);
    }
}
