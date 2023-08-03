using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeAfterDelay : MonoBehaviour
{
    public string sceneNameToLoad; // The name of the scene to load after the delay

    public float delayInSeconds = 2.5f; // The delay time before changing the scene

    // Start is called before the first frame update
    void Start()
    {
        // Invoke the LoadSceneAfterDelay function after the specified delay
        Invoke("LoadSceneAfterDelay", delayInSeconds);
    }

    // Function to load the specified scene
    void LoadSceneAfterDelay()
    {
        SceneManager.LoadScene(sceneNameToLoad);
    }
}
