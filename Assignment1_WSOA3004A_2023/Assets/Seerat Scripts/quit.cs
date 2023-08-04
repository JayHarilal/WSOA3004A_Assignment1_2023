using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class quit : MonoBehaviour
{

    public InputActionReference Q;
    public InputActionReference LP;

    private void OnEnable()
    {
        Q.action.started += QuitGame;

        LP.action.started += LPunch;
    }

    private void OnDisable()
    {
        LP.action.started -= LPunch;
        Q.action.started -= QuitGame;

    }
    private void LPunch(InputAction.CallbackContext obj)
    {
        SceneManager.LoadScene("PlayerVersusOpponent");
    }

    private void QuitGame(InputAction.CallbackContext call)
    {
        Application.Quit();
    }
}
