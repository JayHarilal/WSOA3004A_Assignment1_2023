using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

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
    jumping
}

public enum ATTACKS
{
    shoryuken,
    tatsumaki,
    hadoken,
    standpunch,
    standkick,
    jumppunch,
    jumpkick,
    crouchpunch,
    crouchkick,
    none
}

public class InputStreamer : MonoBehaviour
{
    public List<INPUTS> inputHistory = new List<INPUTS>(); // stores input for certain amount of time
    public List<FrameTimer> clearTimers = new List<FrameTimer>(); // list of timers for each input in history list

    private FrameTimer animLock; // timer which locks control until end of attack

    public ATTACKS anim = ATTACKS.none; // stores which special is being used

    public int animLength = 0; // stores length of animation in frames for timer

    public bool readInput = true; // determines if input is read
    public bool facingRight = true; // determines if character is facing right
    public STATES charState = STATES.standing; // stores character state

    public TextMeshProUGUI special;

    public Vector2 directionInput;
    public InputActionReference dir;
    public InputActionReference LP;
    public InputActionReference MP;
    public InputActionReference HP;
    public InputActionReference LK;
    public InputActionReference MK;
    public InputActionReference HK;
    private bool recovery = false;

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
        anim = ATTACKS.none;
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
            directionInput = dir.action.ReadValue<Vector2>();
        }
        else
        {
            directionInput = dir.action.ReadValue<Vector2>();
            directionInput = new Vector2(directionInput.x * -1, directionInput.y);
        }

        if (directionInput == new Vector2(-0.707107f, 0.707107f))
        {
            InputReader(INPUTS.ub);
        }
        else if (directionInput == new Vector2(0.707107f, 0.707107f))
        {
            InputReader(INPUTS.uf);
        }
        else if (directionInput == new Vector2(-0.707107f, -0.707107f))
        {
            InputReader(INPUTS.db);
        }
        else if (directionInput == new Vector2(0.707107f, -0.707107f))
        {
            InputReader(INPUTS.df);
        }
        else if (directionInput == Vector2.up)
        {
            InputReader(INPUTS.u);
        }
        else if (directionInput == Vector2.down)
        {
            InputReader(INPUTS.d);
        }
        else if (directionInput == Vector2.left)
        {
            InputReader(INPUTS.b);
        }
        else if (directionInput == Vector2.right)
        {
            InputReader(INPUTS.f);

        }
    }

    private void LPunch(InputAction.CallbackContext call)
    {
        InputReader(INPUTS.lp);
        if (charState == STATES.standing && !recovery)
        {
            anim = ATTACKS.standpunch;
            animLength = 20;
            animLock = new FrameTimer(animLength, OnAnimComplete);
            readInput = false;
        }
    }
    private void LKick(InputAction.CallbackContext call)
    {
        InputReader(INPUTS.lk);
    }

    private void OnEnable()
    {
        LP.action.started += LPunch;
        LK.action.started += LKick;
        MP.action.started += MPunch;
        MK.action.started += MKick;
        HP.action.started += HPunch;
        HK.action.started += HKick;
    }

    private void MKick(InputAction.CallbackContext obj)
    {
        InputReader(INPUTS.mk);
    }

    private void MPunch(InputAction.CallbackContext obj)
    {
        InputReader(INPUTS.mp);
    }

    private void OnDisable()
    {
        recovery = true;
        LP.action.started -= LPunch;
        LK.action.started -= LKick;
        MP.action.started -= MPunch;
        MK.action.started -= MKick;
        HP.action.started -= HPunch;
        HK.action.started -= HKick;
        recovery = false;
    }

    private void HKick(InputAction.CallbackContext obj)
    {
        InputReader(INPUTS.hk);
    }

    private void HPunch(InputAction.CallbackContext obj)
    {
        InputReader(INPUTS.hp);
    }

    public void SpecialValidation()
    {
        if (charState == STATES.standing && readInput) // test only if in valid state and inputs are read
            for (int i = 0; i < inputHistory.Count; i++)
            {
                // needs redoing

                #region shoryuken / hadoken
                //if (inputHistory[i] == INPUTS.lp && i >= 3)
                //{
                //    if (inputHistory[i - 3] == INPUTS.f && inputHistory[i - 2] == INPUTS.d && inputHistory[i - 1] == INPUTS.f)
                //    {
                //        inputHistory.RemoveAt(inputHistory.Count - 1);
                //        clearTimers.RemoveAt(inputHistory.Count - 1);
                //        animLength = 90;
                //        anim = SPECIALS.shoryuken;
                //        animLock = new FrameTimer(animLength, OnAnimComplete);
                //        readInput = false;
                //    }
                //    else if (inputHistory[i - 2] == INPUTS.d && inputHistory[i - 1] == INPUTS.f)
                //    {
                //        inputHistory.RemoveAt(inputHistory.Count - 1);
                //        clearTimers.RemoveAt(inputHistory.Count - 1);
                //        animLength = 30;
                //        anim = SPECIALS.hadoken;
                //        animLock = new FrameTimer(animLength, OnAnimComplete);
                //        readInput = false;
                //    }
                //}
                //else if (inputHistory[i] == INPUTS.lp && i == 2)
                //{
                //    if (inputHistory[i - 2] == INPUTS.d && inputHistory[i - 1] == INPUTS.f)
                //    {
                //        inputHistory.RemoveAt(inputHistory.Count - 1);
                //        clearTimers.RemoveAt(inputHistory.Count - 1);
                //        animLength = 30;
                //        anim = SPECIALS.hadoken;
                //        animLock = new FrameTimer(animLength, OnAnimComplete);
                //        readInput = false;
                //    }
                //}
                #endregion

                #region tatsumaki
                //if (inputHistory[i] == INPUTS.lk && i >= 2)
                //{
                //    if (inputHistory[i - 2] == INPUTS.d && inputHistory[i - 1] == INPUTS.b)
                //    {
                //        inputHistory.RemoveAt(inputHistory.Count - 1);
                //        clearTimers.RemoveAt(inputHistory.Count - 1);
                //        animLength = 120;
                //        anim = SPECIALS.tatsumaki;
                //        animLock = new FrameTimer(animLength, OnAnimComplete);
                //        readInput = false;
                //    }
                //}
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
