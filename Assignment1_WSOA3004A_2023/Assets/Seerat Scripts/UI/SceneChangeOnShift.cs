using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeOnShift : MonoBehaviour
{
    public string sceneNameToLoad; // The name of the scene to load after Shift is pressed

    // Update is called once per frame
    void Update()
    {
        // Check if the left Shift or right Shift key is pressed
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            // Load the specified scene
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }
}
