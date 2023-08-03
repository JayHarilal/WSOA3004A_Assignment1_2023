using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeOnEnter : MonoBehaviour
{
    public string sceneNameToLoad; // The name of the scene to load when Enter is pressed

    // Update is called once per frame
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

