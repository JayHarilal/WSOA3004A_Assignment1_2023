using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public enum INPUTS
{
    u, //up
    uf, //up forward
    f, //forward
    df, //down forward
    d, //down
    db, //down back
    b, //back
    ub, //up back
    lp, //light punch
    mp, //medium punch
    hp, //hard punch
    lk, //light kick
    mk, //medium kick
    hk //hard kick
}

public enum STATES
{
    standing,
    crouching,
    jumping,
    attacking
}

public enum SPECIALS
{
    shoryuken,
    tatsumaki,
    hadoken,
    none
}

public class InputStreamer : MonoBehaviour
{
    public List<INPUTS> inputHistory = new List<INPUTS>(); // stores input for certain amount of time
    public List<FrameTimer> clearTimers = new List<FrameTimer>(); // list of timers for each input in history list

    private FrameTimer animLock; // timer which locks control until end of attack

    private SPECIALS anim = SPECIALS.none; // stores which special is being used

    public int animLength = 0; // stores length of animation in frames for timer

    public bool readInput = true; // determines if input is read
    public bool facingRight = true; // determines if character is facing right
    public STATES charState = STATES.standing; // stores character state

    public TextMeshProUGUI special;


    private void Awake()
    {
        // 60 fps lock
        Screen.SetResolution(1024, 768, false);
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 60;
    }


    private void OnClearComplete()
    {
        Debug.Log("[InputStream] OnComplete Timer Callback");
        inputHistory.RemoveAt(0); // remove input from history
        clearTimers.RemoveAt(0); // remove relevent timer from list 
    }


    private void OnAnimComplete()
    {
        Debug.Log($"[Animation: {anim}] OnComplete Timer Callback");
        readInput = true; // return control to player
        anim = SPECIALS.none;
        animLength = 0; // reset

    }


    public void ClearHistory()
    {
        // empty input history 
        inputHistory.Clear();
    }

    public void InputReading()
    {
        if (facingRight)
        {
            if (Input.GetKey(KeyCode.S) && readInput == true)
            {
                InputReader(INPUTS.d);
            }
            if (Input.GetKey(KeyCode.D) && readInput == true)
            {
                InputReader(INPUTS.f);
            }
            if (Input.GetKey(KeyCode.A) && readInput == true)
            {
                InputReader(INPUTS.b);
            }
            if (Input.GetKeyDown(KeyCode.W) && readInput == true)
            {
                InputReader(INPUTS.u);
            }

            if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A) && readInput == true)
            {
                InputReader(INPUTS.db);
            }
            if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S) && readInput == true)
            {
                InputReader(INPUTS.df);
            }
            if (Input.GetKeyDown(KeyCode.D) && Input.GetKeyDown(KeyCode.W) && readInput == true)
            {
                InputReader(INPUTS.uf);
            }
            if (Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.A) && readInput == true)
            {
                InputReader(INPUTS.ub);
            }

            if (Input.GetKeyDown(KeyCode.I) && readInput == true)
            {
                InputReader(INPUTS.lp);
            }
            if (Input.GetKeyDown(KeyCode.J) && readInput == true)
            {
                InputReader(INPUTS.lk);
            }
        }
    }

    public void SpecialValidation()
    {
        if (charState == STATES.standing && readInput) // test only if in valid state and inputs are read
            for (int i = 0; i < inputHistory.Count; i++)
            {
                #region shoryuken / hadoken
                if (inputHistory[i] == INPUTS.lp && i >= 3)
                {
                    if (inputHistory[i - 3] == INPUTS.f && inputHistory[i - 2] == INPUTS.d && inputHistory[i - 1] == INPUTS.f)
                    {
                        inputHistory.RemoveAt(inputHistory.Count - 1);
                        clearTimers.RemoveAt(inputHistory.Count - 1);
                        animLength = 90;
                        anim = SPECIALS.shoryuken;
                        animLock = new FrameTimer(animLength, OnAnimComplete);
                        readInput = false;
                    }
                    else if (inputHistory[i - 2] == INPUTS.d && inputHistory[i - 1] == INPUTS.f)
                    {
                        inputHistory.RemoveAt(inputHistory.Count - 1);
                        clearTimers.RemoveAt(inputHistory.Count - 1);
                        animLength = 30;
                        anim = SPECIALS.hadoken;
                        animLock = new FrameTimer(animLength, OnAnimComplete);
                        readInput = false;
                    }
                }
                else if (inputHistory[i] == INPUTS.lp && i == 2)
                {
                    if (inputHistory[i - 2] == INPUTS.d && inputHistory[i - 1] == INPUTS.f)
                    {
                        inputHistory.RemoveAt(inputHistory.Count - 1);
                        clearTimers.RemoveAt(inputHistory.Count - 1);
                        animLength = 30;
                        anim = SPECIALS.hadoken;
                        animLock = new FrameTimer(animLength, OnAnimComplete);
                        readInput = false;
                    }
                }
                #endregion

                #region tatsumaki
                if (inputHistory[i] == INPUTS.lk && i >= 2)
                {
                    if (inputHistory[i - 2] == INPUTS.d && inputHistory[i - 1] == INPUTS.b)
                    {
                        inputHistory.RemoveAt(inputHistory.Count - 1);
                        clearTimers.RemoveAt(inputHistory.Count - 1);
                        animLength = 120;
                        anim = SPECIALS.tatsumaki;
                        animLock = new FrameTimer(animLength, OnAnimComplete);
                        readInput = false;
                    }
                }
                #endregion
            }
    }

    private void Update()
    {

        if (readInput)
            InputReading();
        else
            animLock.Update();

        if (clearTimers.Count > 0)
            foreach (FrameTimer timer in clearTimers)
            {
                timer.Update();
            }


        SpecialValidation();
        special.text = anim.ToString();
    }

    private void InputReader(INPUTS input)
    {

        if (inputHistory.Count > 0)
        {
            if (input != inputHistory[inputHistory.Count - 1])
            {
                inputHistory.Add(input);
                clearTimers.Add(new FrameTimer(60, OnClearComplete));
            }
            else
            {
                clearTimers[inputHistory.Count - 1].currentFrameCount = 1;
            }
        }
        else
        {
            inputHistory.Add(input);
            clearTimers.Add(new FrameTimer(60, OnClearComplete));
        }

    }




}
