using System;

public class FrameTimer
{
    private readonly int frames;

    public Action onComplete;
    public Action onUpdate;

    public int currentFrameCount;

    private bool isCounting;

    public int NormalisedFrameCount
    {
        get
        {
            return currentFrameCount / frames;
        }
    }

    public FrameTimer(int frames, Action complete = null)
    {
        this.frames = frames;
        onComplete = complete;
        currentFrameCount = 0;
        isCounting = true;
    }

    public void Update()
    {
        if (!isCounting)
        {
            return;
        }
        currentFrameCount++;
        onUpdate?.Invoke();
        UnityEngine.Debug.Log($"Update FrameTimer: {currentFrameCount}");

        if (currentFrameCount >= frames)
        {
            onComplete?.Invoke();
            isCounting = false;
        }
    }
}
