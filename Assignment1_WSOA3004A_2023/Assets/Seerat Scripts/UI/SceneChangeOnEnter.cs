using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class SceneChangeOnEnter : MonoBehaviour
{
    public string sceneNameToLoad; // The name of the scene to load when Enter is pressed

    public InputActionReference LP;

    private void OnEnable()
    {

        LP.action.started += LPunch;
    }

    private void LPunch(InputAction.CallbackContext obj)
    {
        SceneManager.LoadScene("PlayerVersusOpponent");
        Debug.Log("wtf");
    }

    private void OnDisable()
    {
        LP.action.started -= LPunch;
        
    }
    void Update()
    {
        // Check if the Enter key is pressed
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            // Load the specified scene
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }
}

