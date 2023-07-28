using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FPSCounter : MonoBehaviour
{
    public TextMeshProUGUI fpsText;

    private float timer;

    private void Update()
    {
        if (Time.unscaledTime > timer)
        {
            int fps = (int)(1 / Time.unscaledDeltaTime);
            fpsText.text = fps.ToString();
            timer = Time.unscaledTime + 1;
        }
    }
}
