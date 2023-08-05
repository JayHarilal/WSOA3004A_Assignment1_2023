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
    public bool jumping = false;
    public FrameTimer jumpTimer;
    public FrameTimer hadoTimer;
    public bool hadoken;
    public CharacterAnimation charAni;

    public ColliderGeneration SP;
    public ColliderGeneration SK;
    public ColliderGeneration JP;
    public ColliderGeneration JK;
    public ColliderGeneration CP;
    public ColliderGeneration CK;
    public ColliderGeneration T;
    public ColliderGeneration S;
    public ColliderGeneration H;

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

    public void OnJumpComplete()
    {
        charAni.character.SetInteger("state", 0);
        jumping = false;
    }

    private void OnAnimComplete()
    {
        Debug.Log($"[Animation: {anim}] OnComplete Timer Callback");
        readInput = true; // return control to player
        anim = ATTACKS.none;
        animLength = 0; // reset
        if (SP.instancedCollider != null)
            if (SP.instancedCollider.activeSelf)
                Destroy(SP.instancedCollider);
        if (SK.instancedCollider != null)
            if (SK.instancedCollider.activeSelf)
                Destroy(SK.instancedCollider);
        if (JP.instancedCollider != null)
            if (JP.instancedCollider.activeSelf)
                Destroy(JP.instancedCollider);
        if (JK.instancedCollider != null)
            if (JK.instancedCollider.activeSelf)
                Destroy(JK.instancedCollider);
        if (CP.instancedCollider != null)
            if (CP.instancedCollider.activeSelf)
                Destroy(CP.instancedCollider);
        if (CK.instancedCollider != null)
            if (CK.instancedCollider.activeSelf)
                Destroy(CK.instancedCollider);
        if (S.instancedCollider != null)
            if (S.instancedCollider.activeSelf)
                Destroy(S.instancedCollider);
        if (T.instancedCollider != null)
            if (T.instancedCollider.activeSelf)
                Destroy(T.instancedCollider);

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
        if (!SpecialValidation())
            if (charState == STATES.standing)
            {
                anim = ATTACKS.standpunch;
                animLength = 20;
                animLock = new FrameTimer(animLength, OnAnimComplete);
                readInput = false;
                charAni.character.SetTrigger("punch");
            }
            else if (charState == STATES.jumping)
            {
                anim = ATTACKS.jumppunch;
                animLength = 25;
                animLock = new FrameTimer(animLength, OnAnimComplete);
                readInput = false;
                charAni.character.SetTrigger("punch");
            }
            else if (charState == STATES.crouching)
            {
                anim = ATTACKS.crouchpunch;
                animLength = 24;
                animLock = new FrameTimer(animLength, OnAnimComplete);
                readInput = false;
                charAni.character.SetTrigger("punch");
            }
    }
    private void LKick(InputAction.CallbackContext call)
    {
        InputReader(INPUTS.lk);

        if (!SpecialValidation())
            if (charState == STATES.standing)
            {
                anim = ATTACKS.standkick;
                animLength = 21;
                animLock = new FrameTimer(animLength, OnAnimComplete);
                readInput = false;
                charAni.character.SetTrigger("kick");
            }
            else if (charState == STATES.jumping)
            {
                anim = ATTACKS.jumpkick;
                animLength = 29;
                animLock = new FrameTimer(animLength, OnAnimComplete);
                readInput = false;
                charAni.character.SetTrigger("kick");
            }
            else if (charState == STATES.crouching)
            {
                anim = ATTACKS.crouchkick;
                animLength = 26;
                animLock = new FrameTimer(animLength, OnAnimComplete);
                readInput = false;
                charAni.character.SetTrigger("kick");
            }
    }

    private void OnEnable()
    {
        LP.action.started += LPunch;
        LK.action.started += LKick;


    }

    private void OnDisable()
    {
        LP.action.started -= LPunch;
        LK.action.started -= LKick;

    }



    public bool SpecialValidation()
    {
        bool Valid = false;
        if (charState == STATES.standing && readInput || charState == STATES.crouching && readInput) // test only if in valid state and inputs are read
        {
            for (int i = inputHistory.Count - 1; i >= 0; i--)
            {


                #region shoryuken / hadoken
                if (inputHistory[i] == INPUTS.lp && i >= 4)
                {
                    if (inputHistory[i - 3] == INPUTS.f && inputHistory[i - 2] == INPUTS.d && inputHistory[i - 1] == INPUTS.df)
                    {
                        inputHistory.RemoveAt(inputHistory.Count - 1);
                        clearTimers.RemoveAt(inputHistory.Count - 1);
                        animLength = 60;
                        anim = ATTACKS.shoryuken;
                        animLock = new FrameTimer(animLength, OnAnimComplete);
                        readInput = false;
                        charAni.character.SetTrigger("shoryuken");
                        Valid = true;
                    }
                    else if (inputHistory[i - 4] == INPUTS.f && inputHistory[i - 3] == INPUTS.d && inputHistory[i - 2] == INPUTS.df && inputHistory[i - 1] == INPUTS.f)
                    {
                        inputHistory.RemoveAt(inputHistory.Count - 1);
                        clearTimers.RemoveAt(inputHistory.Count - 1);
                        animLength = 60;
                        anim = ATTACKS.shoryuken;
                        animLock = new FrameTimer(animLength, OnAnimComplete);
                        readInput = false;
                        charAni.character.SetTrigger("shoryuken");
                        Valid = true;
                    }
                    else if (inputHistory[i - 3] == INPUTS.d && inputHistory[i - 2] == INPUTS.df && inputHistory[i - 1] == INPUTS.f)
                    {
                        inputHistory.RemoveAt(inputHistory.Count - 1);
                        clearTimers.RemoveAt(inputHistory.Count - 1);
                        animLength = 43;
                        anim = ATTACKS.hadoken;
                        animLock = new FrameTimer(animLength, OnAnimComplete);
                        readInput = false;
                        charAni.character.SetTrigger("hadoken");
                        Valid = true;
                    }
                }
                else if (inputHistory[i] == INPUTS.lp && i == 3)
                {
                    if (inputHistory[i - 3] == INPUTS.d && inputHistory[i - 2] == INPUTS.df && inputHistory[i - 1] == INPUTS.f)
                    {
                        inputHistory.RemoveAt(inputHistory.Count - 1);
                        clearTimers.RemoveAt(inputHistory.Count - 1);
                        animLength = 43;
                        anim = ATTACKS.hadoken;
                        animLock = new FrameTimer(animLength, OnAnimComplete);
                        readInput = false;
                        charAni.character.SetTrigger("hadoken");
                        Valid = true;
                    }
                }
                #endregion

                #region tatsumaki
                if (inputHistory[i] == INPUTS.lk && i >= 3)
                {
                    if (inputHistory[i - 3] == INPUTS.d && inputHistory[i - 2] == INPUTS.db && inputHistory[i - 1] == INPUTS.b)
                    {
                        inputHistory.RemoveAt(inputHistory.Count - 1);
                        clearTimers.RemoveAt(inputHistory.Count - 1);
                        animLength = 97;
                        anim = ATTACKS.tatsumaki;
                        animLock = new FrameTimer(animLength, OnAnimComplete);
                        readInput = false;
                        charAni.character.SetTrigger("tatsumaki");
                        Valid = true;

                    }
                }
                #endregion
            }
        }

        return Valid;
    }

    private void Update()
    {
        if (jumping)
            jumpTimer.Update();


        if (readInput)
            InputReading();
        else
        {

            animLock.Update();
            if (anim == ATTACKS.standpunch)
            {
                if (SP.instancedCollider != null)
                    if (!SP.instancedCollider.activeSelf)
                        SP.Generate();
                    else
                        SP.instancedCollider.transform.position = SP.NewPos();
                else
                    SP.Generate();
            }
            else if (anim == ATTACKS.standkick)
            {
                if (SK.instancedCollider != null)
                    if (!SK.instancedCollider.activeSelf)
                        SK.Generate();
                    else
                        SK.instancedCollider.transform.position = SK.NewPos();
                else
                    SK.Generate();
            }
            else if (anim == ATTACKS.jumppunch)
            {
                if (JP.instancedCollider != null)
                    if (!JP.instancedCollider.activeSelf)
                        JP.Generate();
                    else
                        JP.instancedCollider.transform.position = JP.NewPos();
                else
                    JP.Generate();
            }
            else if (anim == ATTACKS.jumpkick)
            {
                if (JK.instancedCollider != null)
                    if (!JK.instancedCollider.activeSelf)
                        JK.Generate();
                    else
                        JK.instancedCollider.transform.position = JK.NewPos();
                else
                    JK.Generate();
            }
            else if (anim == ATTACKS.crouchpunch)
            {
                if (CP.instancedCollider != null)
                    if (!CP.instancedCollider.activeSelf)
                        CP.Generate();
                    else
                        CP.instancedCollider.transform.position = CP.NewPos();
                else
                    CP.Generate();
            }
            else if (anim == ATTACKS.crouchkick)
            {
                if (CK.instancedCollider != null)
                    if (!CK.instancedCollider.activeSelf)
                        CK.Generate();
                    else
                        CK.instancedCollider.transform.position = CK.NewPos();
                else
                    CK.Generate();
            }
            else if (anim == ATTACKS.tatsumaki)
            {
                if (T.instancedCollider != null)
                    if (!T.instancedCollider.activeSelf)
                        T.Generate();
                    else
                        T.instancedCollider.transform.position = T.NewPos();
                else
                    T.Generate();
            }
            else if (anim == ATTACKS.shoryuken)
            {
                if (S.instancedCollider != null)
                    if (!S.instancedCollider.activeSelf)
                        S.Generate();
                    else
                        S.instancedCollider.transform.position = S.NewPos();
                else
                    S.Generate();
            }
            else if (anim == ATTACKS.hadoken)
            {
                hadoTimer = new FrameTimer(2, OnHadoStartComplete);
                hadoken = true;
            }
        }

        if (clearTimers.Count > 0)
            foreach (FrameTimer timer in clearTimers)
            {
                timer.Update();
            }

        if (hadoken)
            hadoTimer.Update();
    }

    private void OnHadoStartComplete()
    {
        hadoken = false;
        if (H.instancedCollider != null)
            if (!H.instancedCollider.activeSelf)
                H.Generate();
            else
                H.instancedCollider.transform.position = H.NewPos();
        else
            H.Generate();

        hadoTimer = new FrameTimer(60, OnHadoTravelComplete);
    }

    private void OnHadoTravelComplete()
    {
        H.GetComponent<Animator>().SetTrigger("Hit");
        hadoTimer = new FrameTimer(21, OnHadoHitComplete);
    }

    public void OnHadoHitComplete()
    {
        if (H.instancedCollider != null)
            if (H.instancedCollider.activeSelf)
                Destroy(H.instancedCollider);
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
