using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private FrameTimer gameTimer;
    public TextMeshProUGUI timerText;
    public int timeRemaining = 60;

    private void Start()
    {
        gameTimer = new FrameTimer(60, OnTimerComplete);
    }

    private void Update()
    {
        gameTimer.Update();
        timerText.text = timeRemaining.ToString();
    }

    private void OnTimerComplete()
    {
        Debug.Log("[Timer] OnComplete Timer Callback");
        timeRemaining--;
        if (timeRemaining > 0)
            gameTimer = new FrameTimer(60, OnTimerComplete);
    }
}
