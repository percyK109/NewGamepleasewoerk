using UnityEngine;
using TMPro;  // Import TextMeshPro namespace

public class Timer : MonoBehaviour
{
    public float TimeLeft;
    public bool TimerOn = false;
    public bool TimeLimit = false;

    public TextMeshProUGUI TimerTxt;  // Change to TextMeshProUGUI
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TimerOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (TimerOn)
        {
            if (TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                updateTimer(TimeLeft);
            }
            else
            {
                Debug.Log("Time is Up!");
                TimeLeft = 0;
                TimerOn = false;

            }
        }
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;  // Adjusting by +1 here, seems like you want to round up the timer display
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);
        TimerTxt.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}